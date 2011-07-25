using System;
using System.ComponentModel;
using System.IO;
using Caliburn.Micro.Contrib.Helper;
using Ookii.Dialogs.Wpf;

namespace Caliburn.Micro.Contrib.Results
{
    /// <summary>
    ///   A custom Caliburn.Micro result which shows a SaveFileDialog to the user.
    ///   You can also directly perform an action on the selected file inside the result
    /// </summary>
    public class SaveFileResult : IResult
    {
        private readonly FileFilterCollection _filters = new FileFilterCollection();
        private readonly string _title;
        private bool _cancelled = true;
        private EventHandler<ResultCompletionEventArgs> _completed = delegate { };
        private Action<string> _fileAction;
        private bool _ignoreUserCancel;
        private string _initialDirectory;
        private bool _promptForCreate;
        private bool _promptForOverwrite;

        /// <summary>
        ///   Creates a new SaveFileResult.
        /// </summary>
        /// <param name = "title">The title of the dialog window</param>
        public SaveFileResult(string title = null)
        {
            _title = title;
        }

        /// <summary>
        ///   The name of the file selected by the user.
        /// </summary>
        public string FileName { get; private set; }

        #region IResult Members

        void IResult.Execute(ActionExecutionContext context)
        {
            VistaSaveFileDialog dialog = CreateDialog();

            dialog.FileOk += FileOk;

            dialog.ShowDialog();

            if (_cancelled)
            {
                _completed(this, new ResultCompletionEventArgs {WasCancelled = !_ignoreUserCancel});
            }
        }

        event EventHandler<ResultCompletionEventArgs> IResult.Completed
        {
            add { _completed += value; }
            remove { _completed -= value; }
        }

        #endregion

        private void OnCompleted(VistaSaveFileDialog dialog, ResultCompletionEventArgs args)
        {
            dialog.FileOk -= FileOk;

            _completed(this, args);
        }

        private void FileOk(object sender, CancelEventArgs args)
        {
            _cancelled = false;
            var dialog = (sender as VistaSaveFileDialog);

            var resultArgs = new ResultCompletionEventArgs();

            FileName = dialog.FileName;

            if (_fileAction != null)
            {
                try
                {
                    _fileAction(FileName);
                }
                catch (Exception e)
                {
                    resultArgs.Error = e;
                    args.Cancel = true;
                }
            }

            OnCompleted(dialog, resultArgs);
        }

        /// <summary>
        ///   Creates the dialog with the user specified settings. Can be overridden to change the default settings
        /// </summary>
        /// <returns></returns>
        protected virtual VistaSaveFileDialog CreateDialog()
        {
            var dialog = new VistaSaveFileDialog();
            dialog.DefaultExt = _filters.DefaultExtension;
            dialog.Title = _title;
            dialog.Filter = _filters.CreateFilterExpression();
            dialog.InitialDirectory = _initialDirectory;
            dialog.OverwritePrompt = _promptForOverwrite;
            dialog.CreatePrompt = _promptForCreate;

            dialog.AddExtension = true;
            dialog.CheckPathExists = true;

            return dialog;
        }

        /// <summary>
        ///   Performs an action on the selected file before the result is completed
        /// </summary>
        /// <param name = "action">The action to be performed</param>
        /// <returns></returns>
        public SaveFileResult WithFileDo(Action<string> action)
        {
            _fileAction = action;

            return this;
        }

        /// <summary>
        ///   Create file filter for the dialog
        /// </summary>
        /// <param name = "action"></param>
        /// <returns></returns>
        public SaveFileResult FilterFiles(Action<FileFilterCollection> action)
        {
            if (action == null) throw new ArgumentNullException("action may not be null");
            action(_filters);

            return this;
        }

        /// <summary>
        ///   Sets the inital <paramref name = "directory" /> of the dialog
        /// </summary>
        /// <param name = "directory"></param>
        /// <returns></returns>
        public SaveFileResult In(string directory)
        {
            if (!Directory.Exists(directory)) throw new ArgumentException(string.Format("Directory '{0}' doesn't exist", directory));

            _initialDirectory = directory;

            return this;
        }

        /// <summary>
        ///   Ask the user for permission if the file will be overriden
        /// </summary>
        /// <returns></returns>
        public SaveFileResult PromptForOverwrite()
        {
            _promptForOverwrite = true;

            return this;
        }

        /// <summary>
        ///   Ask the user for permission if a new file will be created
        /// </summary>
        /// <returns></returns>
        public SaveFileResult PromptForCreate()
        {
            _promptForCreate = true;

            return this;
        }

        /// <summary>
        ///   Dont cancel the execution of the coroutine if the user cancels the dialog
        /// </summary>
        /// <returns></returns>
        public SaveFileResult IgnoreUserCancel()
        {
            _ignoreUserCancel = true;

            return this;
        }
    }
}