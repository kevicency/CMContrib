using System;
using System.Collections.Generic;

namespace Caliburn.Micro.Contrib.Results
{
    public abstract class OpenResultBase<TTarget> : IOpenResult<TTarget>
    {
        protected IOpenResult<TTarget> OpenResult
        {
            get { return this; }
        }

        #region IOpenResult<TTarget> Members

        Func<TTarget, IEnumerable<IResult>> IOpenResult<TTarget>.BeforeActivation { get; set; }

        Func<TTarget, IEnumerable<IResult>> IOpenResult<TTarget>.AfterActivation { get; set; }

        Func<TTarget, IEnumerable<IResult>> IOpenResult<TTarget>.AfterClosing { get; set; }

        Func<TTarget, IEnumerable<IResult>> IOpenResult<TTarget>.BeforeClosing { get; set; }

        event EventHandler<ResultCompletionEventArgs> IResult.Completed
        {
            add { _completed += value; }
            remove { _completed -= value; }
        }

        void IResult.Execute(ActionExecutionContext context)
        {
            Execute(context);
        }

        #endregion

        protected abstract void Execute(ActionExecutionContext context);

        private event EventHandler<ResultCompletionEventArgs> _completed = delegate { };

        protected virtual void OnCompleted(Exception exception, bool wasCancelled)
        {
            _completed(this, new ResultCompletionEventArgs {Error = exception, WasCancelled = wasCancelled});
        }
    }
}