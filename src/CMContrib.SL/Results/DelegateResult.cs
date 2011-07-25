using System;

namespace Caliburn.Micro.Contrib.Results
{
    public class DelegateResult : IResult
    {
        private readonly System.Action _action;

        public DelegateResult(System.Action action)
        {
            _action = action;
        }

        #region IResult Members

        public void Execute(ActionExecutionContext context)
        {
            var resultArgs = new ResultCompletionEventArgs();

            try
            {
                _action();
            }
            catch (Exception e)
            {
                resultArgs.Error = e;
            }

            Completed(this, resultArgs);
        }

        public event EventHandler<ResultCompletionEventArgs> Completed;

        #endregion
    }
}