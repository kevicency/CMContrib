using System;
using System.Collections.Generic;

namespace Caliburn.Micro.Contrib.Decorators
{
    /// <summary>
    ///   A result decorator which executes a coroutine when the inner result was cancelled
    /// </summary>
    internal class ContinueResultDecorator : ResultDecoratorBase
    {
        static readonly ILog _log = LogManager.GetLog(typeof (ContinueResultDecorator));

        readonly Func<IEnumerable<IResult>> _coroutine;
        ActionExecutionContext _context;

        public ContinueResultDecorator(IResult inner, Func<IEnumerable<IResult>> coroutine)
            : base(inner)
        {
            if (coroutine == null) throw new ArgumentNullException("coroutine");

            _coroutine = coroutine;
        }

        static ILog Log
        {
            get { return _log; }
        }

        public override void Execute(ActionExecutionContext context)
        {
            _context = context;
            base.Execute(context);
        }

        protected override void InnerCompleted(object sender, ResultCompletionEventArgs args)
        {
            base.InnerCompleted(sender, args);

            if (args.Error != null || !args.WasCancelled)
            {
                OnCompleted(new ResultCompletionEventArgs {Error = args.Error});
            }
            else
            {
                Log.Info(string.Format("Executing coroutine because {0} was cancelled", Inner.GetType().Name));

                var cancelResult = new SequentialResult(_coroutine().GetEnumerator());
                cancelResult.Completed += HandleCancelCompleted;

                cancelResult.Execute(_context);
            }
        }

        void HandleCancelCompleted(object sender, ResultCompletionEventArgs args)
        {
            (sender as IResult).Completed -= HandleCancelCompleted;

            OnCompleted(new ResultCompletionEventArgs {Error = args.Error, WasCancelled = true});
        }
    }
}