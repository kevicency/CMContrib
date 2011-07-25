using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using Caliburn.Micro.Contrib.Helper;
using Ookii.Dialogs.Wpf;

namespace Caliburn.Micro.Contrib.Results
{
    /// <summary>
    ///   A Caliburn.Micro result which shows an OpenFileDialog to user, allowing him to select one (default) or more files.
    ///   You can also directly perform an action on the selected file(s) inside the result.
    /// </summary>
    public class OpenFileResult : IResult
    {
        private readonly FileFilterCollection _filters = new FileFilterCollection();
        private readonly string _title;
        private bool _allowMultipleFiles;
        private bool _cancelled = true;
        private EventHandler<ResultCompletionEventArgs> _completed = delegate { };
        private Action<string[]> _fileAction;
        private bool _ignoreUserCancel;
        private string _initialDirectory;

        /// <summary>
        ///   Creates a new OpenFileResult
        /// </summary>
        /// <param name = "title">The title of the dialog</param>
        public OpenFileResult(string title = null)
        {
            _title = title;
        }

        /// <summary>
        ///   The name of the file selected by the user. If the user selected multiple files, this property will return the first name in the FileNames array
        /// </summary>
        public string FileName
        {
            get { return FileNames.Any() ? FileNames[0] : null; }
        }

        /// <summary>
        ///   The name of all files the user selected.
        /// </summary>
        public string[] FileNames { get; private set; }

        #region IResult Members

        void IResult.Execute(ActionExecutionContext context)
        {
            VistaOpenFileDialog dialog = CreateDialog();

            dialog.FileOk += FileOk;

            dialog.ShowDialog();

            if (_cancelled)
            {
                OnCompleted(dialog, new ResultCompletionEventArgs {WasCancelled = !_ignoreUserCancel});
            }
        }

        event EventHandler<ResultCompletionEventArgs> IResult.Completed
        {
            add { _completed += value; }
            remove { _completed -= value; }
        }

        #endregion

        private void FileOk(object sender, CancelEventArgs args)
        {
            _cancelled = false;

            var resultArgs = new ResultCompletionEventArgs();
            var dialog = (sender as VistaOpenFileDialog);

            if (args.Cancel)
            {
                resultArgs.WasCancelled = !_ignoreUserCancel;
            }
            else
            {
                FileNames = dialog.FileNames;

                if (_fileAction != null)
                {
                    try
                    {
                        _fileAction(FileNames);
                    }
                    catch (Exception e)
                    {
                        resultArgs.Error = e;
                    }
                }
            }

            OnCompleted(dialog, resultArgs);
        }

        private void OnCompleted(VistaOpenFileDialog dialog, ResultCompletionEventArgs args)
        {
            dialog.FileOk -= FileOk;

            _completed(this, args);
        }

        /// <summary>
        ///   Creates the dialog with the user specified settings.
        ///   Can be overridden to change the default settings
        /// </summary>
        /// <returns></returns>
        protected virtual VistaOpenFileDialog CreateDialog()
        {
            var dialog = new VistaOpenFileDialog();
            dialog.Title = _title;
            dialog.Filter = _filters.CreateFilterExpression();
            dialog.InitialDirectory = _initialDirectory;
            dialog.Multiselect = _allowMultipleFiles;

            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;

            return dialog;
        }

        /// <summary>
        ///   Performs an action on the selected file before the result is completed
        /// </summary>
        /// <param name = "action"></param>
        /// <returns></returns>
        public OpenFileResult WithFileDo(Action<string> action)
        {
            _fileAction = files => action(files[0]);

            return this;
        }

        /// <summary>
        ///   Performs an action on the selected files before the result is completed
        /// </summary>
        /// <param name = "action"></param>
        /// <returns></returns>
        public OpenFileResult WithFilesDo(Action<string[]> action)
        {
            _fileAction = action;

            return this;
        }

        /// <summary>
        ///   Create file filter for the dialog
        /// </summary>
        /// <param name = "action"></param>
        /// <returns></returns>
        public OpenFileResult FilterFiles(Action<FileFilterCollection> action)
        {
            if (action == null) throw new ArgumentNullException("action may not be null");
            action(_filters);

            return this;
        }

        /// <summary>
        ///   Sets the initial <paramref name = "directory" /> of the dialog
        /// </summary>
        /// <param name = "directory"></param>
        /// <returns></returns>
        public OpenFileResult In(string directory)
        {
            if (!Directory.Exists(directory)) throw new ArgumentException(string.Format("Directory '{0}' doesn't exist", directory));

            _initialDirectory = directory;

            return this;
        }

        /// <summary>
        ///   Allow the user to select multiple files
        /// </summary>
        /// <returns></returns>
        public OpenFileResult AllowMultipleFiles()
        {
            _allowMultipleFiles = true;

            return this;
        }

        /// <summary>
        ///   Dont cancel the execution of the coroutine if the user cancels the dialog
        /// </summary>
        /// <returns></returns>
        public OpenFileResult IgnoreUserCancel()
        {
            _ignoreUserCancel = true;

            return this;
        }
    }
}