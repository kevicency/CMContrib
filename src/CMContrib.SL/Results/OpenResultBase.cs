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

        #endregion

        public abstract void Execute(ActionExecutionContext context);

        private event EventHandler<ResultCompletionEventArgs> _completed = delegate { };

        protected void OnCompleted(Exception exception, bool wasCancelled)
        {
            OnCompleted(new ResultCompletionEventArgs {Error = exception, WasCancelled = wasCancelled});
        }

        protected virtual void OnCompleted(ResultCompletionEventArgs args)
        {
            _completed(this, args);
        }
    }
}