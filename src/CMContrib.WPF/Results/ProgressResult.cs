using System;
using System.ComponentModel;
using Ookii.Dialogs.Wpf;

namespace Caliburn.Micro.Contrib.Results
{
    public class ProgressResult : ProgressResult<object, object>
    {
        public ProgressResult(string title)
            : base(title)
        {
        }
    }

    public class ProgressResult<TParameter, TResult> : IResult
    {
        private readonly string _title;
        private bool _canCancel;
        private Action<TParameter> _cancelAction;
        private string _cancellationText;
        private EventHandler<ResultCompletionEventArgs> _completed = delegate { };
        private string _description;
        public DoWorkEventHandler _handler;
        private TParameter _parameter;
        private Action<TParameter, TResult> _resultAction;
        private bool _showTimeRemaining;
        private string _text;

        public ProgressResult(string title)
        {
            _title = title;
        }

        public TResult Result { get; private set; }

        #region IResult Members

        void IResult.Execute(ActionExecutionContext context)
        {
            ProgressDialog progressDialog = CreateDialog();

            progressDialog.RunWorkerCompleted += OnWorkerCompleted;


            progressDialog.Show(_parameter);
        }

        event EventHandler<ResultCompletionEventArgs> IResult.Completed
        {
            add { _completed += value; }
            remove { _completed -= value; }
        }

        #endregion

        private void OnWorkerCompleted(object sender, RunWorkerCompletedEventArgs args)
        {
            (sender as ProgressDialog).RunWorkerCompleted -= OnWorkerCompleted;
            var resultArgs = new ResultCompletionEventArgs();

            if (args.Error != null) resultArgs.Error = args.Error;
            else if (args.Cancelled)
            {
                resultArgs.WasCancelled = true;
                if (_cancelAction != null) _cancelAction(_parameter);
            }
            else if (args.Result is TResult)
            {
                Result = (TResult) args.Result;
                if (_resultAction != null)
                {
                    try
                    {
                        _resultAction(_parameter, Result);
                    }
                    catch (Exception e)
                    {
                        resultArgs.Error = e;
                    }
                }
            }
            else
            {
                string message = string.Format("Result not of type {0}",
                                               typeof (TResult).Name);
                resultArgs.Error = new Exception(message);
            }
            _completed(this, resultArgs);
        }

        private void OnWorkerError(Exception e)
        {
            _completed(this, new ResultCompletionEventArgs {Error = e});
        }

        /// <summary>
        ///   Creates the dialog.
        ///   Override to change default behavior
        /// </summary>
        /// <returns></returns>
        protected ProgressDialog CreateDialog()
        {
            var progressDialog = new ProgressDialog();
            progressDialog.DoWork += _handler;
            progressDialog.WindowTitle = _title;
            progressDialog.Text = _text;
            progressDialog.Description = _description;
            progressDialog.ShowTimeRemaining = _showTimeRemaining;
            progressDialog.ShowCancelButton = _canCancel;
            progressDialog.CancellationText = _cancellationText;

            return progressDialog;
        }

        public ProgressResult<TParameter, TResult> SetProgressDescription(string description)
        {
            _description = description;

            return this;
        }

        public ProgressResult<TParameter, TResult> SetText(string text)
        {
            _text = text;

            return this;
        }

        public ProgressResult<TParameter, TResult> UseParameter(TParameter parameter)
        {
            _parameter = parameter;

            return this;
        }

        public ProgressResult<TParameter, TResult> Start(DoWorkEventHandler handler)
        {
            _handler = (s, e) =>
                       {
                           try
                           {
                               handler(s, e);
                           }
                           catch (Exception ex)
                           {
                               OnWorkerError(ex);
                           }
                       };

            return this;
        }

        public ProgressResult<TParameter, TResult> ShowTimeRemaining()
        {
            _showTimeRemaining = true;

            return this;
        }


        public ProgressResult<TParameter, TResult> WithResultDo(Action<TParameter, TResult> action)
        {
            _resultAction = action;

            return this;
        }

        public ProgressResult<TParameter, TResult> WithResultDo(Action<TResult> action)
        {
            _resultAction = (arg, res) => action(res);

            return this;
        }

        public ProgressResult<TParameter, TResult> WhenCancelledDo(Action<TParameter> action)
        {
            _cancelAction = action;

            return this;
        }

        public ProgressResult<TParameter, TResult> WhenCancelledDo(System.Action action)
        {
            _cancelAction = x => action();

            return this;
        }

        public ProgressResult<TParameter, TResult> AllowCancel(string cancellationText)
        {
            _cancellationText = cancellationText;
            _canCancel = true;

            return this;
        }
    }
}