using System;
using Caliburn.Micro.Contrib.Results;

namespace Caliburn.Micro.Contrib.Decorators
{
    public class BusyResultDecorator : BusyResultBase
    {
        readonly IResult _inner;
        readonly string _message;
        ActionExecutionContext _context;

        internal BusyResultDecorator(IResult inner, string message)
        {
            _inner = inner;
            _message = message;
        }

        public override void Execute(ActionExecutionContext context)
        {
            _context = context;

            UpdateIndicator(context, _message);

            // Wrap the inner result in a SequentialResult s.t. it gets injected by the container but avoid deep nesting
            var wrapper = (_inner is SequentialResult || _inner is ResultDecoratorBase)
                              ? _inner
                              : new SequentialResult(new SingleResultEnumerator(_inner));

            wrapper.Completed += OnInnerCompleted;

            wrapper.Execute(context);
        }

        void OnInnerCompleted(object sender, ResultCompletionEventArgs e)
        {
            _inner.Completed -= OnInnerCompleted;
            UpdateIndicator(_context, null);

            Completed(this, e);
        }

        public override event EventHandler<ResultCompletionEventArgs> Completed = delegate { };
    }
}