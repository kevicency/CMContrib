using System;

namespace Caliburn.Micro.Contrib.Decorators
{
    public class ResultDecoratorBase : IResult
    {
        private readonly IResult _inner;

        internal ResultDecoratorBase(IResult inner)
        {
            if (inner == null) throw new ArgumentNullException("inner");

            _inner = inner;
        }

        public IResult Inner
        {
            get { return _inner; }
        }

        #region IResult Members

        public virtual void Execute(ActionExecutionContext context)
        {
            var wrapper = _inner is SequentialResult
                                  ? _inner
                                  : new SequentialResult(new SingleResultEnumerator(_inner));

            wrapper.Completed += InnerCompleted;

            wrapper.Execute(context);
        }

        public virtual event EventHandler<ResultCompletionEventArgs> Completed;

        #endregion

        protected virtual void OnCompleted(ResultCompletionEventArgs args)
        {
            if (Completed != null) Completed(this, args);
        }

        protected virtual void InnerCompleted(object sender, ResultCompletionEventArgs args)
        {
            (sender as IResult).Completed -= InnerCompleted;
        }
    }
}