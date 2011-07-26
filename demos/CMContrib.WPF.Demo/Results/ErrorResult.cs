using System;

namespace Caliburn.Micro.Contrib.Demo.Results
{
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