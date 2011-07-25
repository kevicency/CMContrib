using System;
using System.Collections.Generic;
using System.Text;

namespace Caliburn.Micro.Contrib.Decorators
{
    internal class CatchResultDecorator : ResultDecoratorBase
    {
        private static readonly ILog _log = LogManager.GetLog(typeof(CatchResultDecorator));
        private readonly Func<Exception, IEnumerable<IResult>> _handler;
        private ActionExecutionContext _context;

        public CatchResultDecorator(IResult inner, Func<Exception, IEnumerable<IResult>> handler)
            : base(inner)
        {
            _handler = handler;
        }

        private static ILog Log
        {
            get { return _log; }
        }

        public override void Execute(ActionExecutionContext context)
        {
            _context = context;
            try
            {
                base.Execute(context);
                OnCompleted(new ResultCompletionEventArgs());
            }
            catch (Exception e)
            {
                Handle(e);
            }
        }

        private void Handle(Exception exception)
        {
            LogCatchedException(exception);

            var catchResult = new SequentialResult(_handler(exception).GetEnumerator());
            catchResult.Completed += CatchCompleted;

            catchResult.Execute(_context);
        }

        private void CatchCompleted(object sender, ResultCompletionEventArgs args)
        {
            (sender as IResult).Completed -= CatchCompleted;

            OnCompleted(new ResultCompletionEventArgs { Error = args.Error, WasCancelled = args.WasCancelled});
        }

        private void LogCatchedException(Exception exception)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("Catched {0}", exception.GetType().FullName).AppendLine();
            sb.AppendLine(exception.Message);
            sb.AppendLine(exception.StackTrace);

            Log.Info(sb.ToString());
        }

        protected override void InnerCompleted(object sender, ResultCompletionEventArgs args)
        {
            base.InnerCompleted(sender, args);

            OnCompleted(new ResultCompletionEventArgs() { Error = args.Error, WasCancelled = args.WasCancelled });
        }
    }
}