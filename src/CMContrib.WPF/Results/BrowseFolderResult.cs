using System;
using System.Windows.Forms;

namespace Caliburn.Micro.Contrib.Results
{
    /// <summary>
    ///   A Caliburn.Micro result which shows an BrowseFolderDialog to user, allowing him to select a folder.
    ///   You can also directly perform an action on the selected folder inside the result.
    /// </summary>
    public class BrowseFolderResult : IResult
    {
        private readonly string _title;
        private bool _allowNewFolder;
        private EventHandler<ResultCompletionEventArgs> _completed = delegate { };
        private bool _ignoreUserCancel;
        private Action<string> _pathAction;
        private Environment.SpecialFolder _rootFolder = Environment.SpecialFolder.MyDocuments;

        /// <summary>
        ///   Creates a new BrowseFolderResult
        /// </summary>
        /// <param name = "title">The title of the dialog</param>
        public BrowseFolderResult(string title = null)
        {
            _title = title;
        }

        public string SelectedPath { get; private set; }

        #region IResult Members

        event EventHandler<ResultCompletionEventArgs> IResult.Completed
        {
            add { _completed += value; }
            remove { _completed += value; }
        }

        void IResult.Execute(ActionExecutionContext context)
        {
            var dialog = CreateDialog();

            dialog.ShowDialog();

            var resultArgs = new ResultCompletionEventArgs();
            bool cancelled = string.IsNullOrWhiteSpace(dialog.SelectedPath);

            if (cancelled)
            {
                resultArgs.WasCancelled = !_ignoreUserCancel;
            }
            else
            {
                SelectedPath = dialog.SelectedPath;

                if (_pathAction != null)
                {
                    try
                    {
                        _pathAction(SelectedPath);
                    }
                    catch (Exception e)
                    {
                        resultArgs.Error = e;
                    }
                }
            }

            _completed(this, resultArgs);
        }

        #endregion

        /// <summary>
        ///   Creates the dialog with the user specified settings.
        ///   Can be overridden to change the default settings
        /// </summary>
        /// <returns></returns>
        protected virtual FolderBrowserDialog CreateDialog()
        {
            var dialog = new FolderBrowserDialog();
            dialog.RootFolder = _rootFolder;
            dialog.Description = _title;
            dialog.ShowNewFolderButton = _allowNewFolder;

            return dialog;
        }

        /// <summary>
        ///   Allow the user to create a new folder inside the folder browser
        /// </summary>
        /// <returns></returns>
        public BrowseFolderResult AllowNewFolder()
        {
            _allowNewFolder = true;

            return this;
        }

        /// <summary>
        ///   Sets the default folder for the dialog
        /// </summary>
        /// <param name = "rootFolder"></param>
        /// <returns></returns>
        public BrowseFolderResult In(Environment.SpecialFolder rootFolder)
        {
            _rootFolder = rootFolder;

            return this;
        }

        /// <summary>
        ///   Performs an action on the selected path before the result is completed
        /// </summary>
        /// <param name = "action"></param>
        /// <returns></returns>
        public BrowseFolderResult WithSelectedPathDo(Action<string> action)
        {
            _pathAction = action;

            return this;
        }


        /// <summary>
        ///   Don't cancel the execution of the coroutine if the user cancels the dialog
        /// </summary>
        /// <returns></returns>
        public BrowseFolderResult IgnoreUserCancel()
        {
            _ignoreUserCancel = true;

            return this;
        }
    }
}