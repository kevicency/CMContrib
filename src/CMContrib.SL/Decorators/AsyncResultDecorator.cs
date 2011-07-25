using System;
using System.Threading;

namespace Caliburn.Micro.Contrib.Decorators
{
    /// <summary>
    ///   A result decorator which delegates the execution of the inner result to the thread pool
    /// </summary>
    internal class AsyncResultDecorator : ResultDecoratorBase
    {
        private static readonly ILog _log = LogManager.GetLog(typeof (AsyncResultDecorator));

        private readonly IResult _inner;

        public AsyncResultDecorator(IResult inner)
            : base(inner)
        {
            if (inner == null) throw new ArgumentNullException("inner");

            _inner = inner;
        }

        private static ILog Log
        {
            get { return _log; }
        }

        public override void Execute(ActionExecutionContext context)
        {
            ThreadPool.QueueUserWorkItem(x =>
                                         {
                                             _inner.Completed += InnerCompleted;
                                             _inner.Execute(context);
                                         });
        }


        protected override void InnerCompleted(object sender, ResultCompletionEventArgs e)
        {
            base.InnerCompleted(sender, e);

            Micro.Execute.OnUIThread(
                () => OnCompleted(new ResultCompletionEventArgs {WasCancelled = e.WasCancelled, Error = e.Error}));
        }
    }
}