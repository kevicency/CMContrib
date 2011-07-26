using System;

namespace Caliburn.Micro.Contrib.Demo.Results
{
    internal class CancelResult : IResult
    {
        #region IResult Members

        public void Execute(ActionExecutionContext context)
        {
            Completed(this, new ResultCompletionEventArgs { WasCancelled = true });
        }

        public event EventHandler<ResultCompletionEventArgs> Completed;

        #endregion
    }
}