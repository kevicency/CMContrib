using System;

namespace Caliburn.Micro.Contrib.WPF.Demo.Results
{
    public class LogResult : IResult
    {
        private readonly string _message;

        public LogResult(string message)
        {
            this._message = message;
        }

        public IShell Shell { get; set; }

        public void Execute(ActionExecutionContext context)
        {
            IoC.Get<IShell>().Log(_message);
            Completed(this, new ResultCompletionEventArgs());
        }

        public event EventHandler<ResultCompletionEventArgs> Completed;
    }

    internal class ErrorResult : IResult
    {
        private readonly Exception _error;

        public ErrorResult(Exception error)
        {
            _error = error;
        }

        #region IResult Members

        public void Execute(ActionExecutionContext context)
        {
            Completed(this, new ResultCompletionEventArgs { Error = _error });
        }

        public event EventHandler<ResultCompletionEventArgs> Completed;

        #endregion
    }
}