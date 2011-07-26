using System;
using System.Collections.Generic;
using System.Text;

namespace Caliburn.Micro.Contrib.Decorators
{
    /// <summary>
    ///   A result decorator which rescues errors from the inner result by executing a rescue coroutine
    /// </summary>
    internal class RescueResultDecorator : RescueResultDecorator<Exception>
    {
        public RescueResultDecorator(IResult inner, Func<Exception, IEnumerable<IResult>> rescue, bool cancelResult)
            : base(inner, rescue, cancelResult)
        {
        }
    }

    /// <summary>
    ///   A result decorator which rescues errors from the inner result by executing a rescue coroutine
    /// </summary>
    /// <typeparam name = "TException">The type of the exception we want to perform the rescue on</typeparam>
    internal class RescueResultDecorator<TException> : ResultDecoratorBase
        where TException : Exception
    {
        private static readonly ILog _log = LogManager.GetLog(typeof (RescueResultDecorator<>));
        private readonly bool _cancelResult;
        private readonly Func<TException, IEnumerable<IResult>> _rescue;
        private ActionExecutionContext _context;

        public RescueResultDecorator(IResult inner, Func<TException, IEnumerable<IResult>> rescue, bool cancelResult)
            : base(inner)
        {
            if (rescue == null) throw new ArgumentNullException("rescue");

            _rescue = rescue;
            _cancelResult = cancelResult;
        }

        protected bool CancelResult
        {
            get { return _cancelResult; }
        }

        private static ILog Log
        {
            get { return _log; }
        }

        private static void LogRescuedError(TException error)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("Rescued {0}", error.GetType().FullName).AppendLine();
            sb.AppendLine(error.Message);
            sb.AppendLine(error.StackTrace);

            Log.Info(sb.ToString());
        }

        public override void Execute(ActionExecutionContext context)
        {
            _context = context;
            try
            {
                base.Execute(context);
            }
            catch (TException e)
            {
                Handle(e);
            }
        }
        
        private void Handle(TException error)
        {
            LogRescuedError(error);

            try
            {
                Rescue(error);
            }
            catch (Exception e)
            {
                Log.Error(e);
                OnCompleted(new ResultCompletionEventArgs {Error = e});
            }
        }

        protected override void InnerCompleted(object sender, ResultCompletionEventArgs args)
        {
            base.InnerCompleted(sender, args);

            if (args.Error is TException)
            {
                Handle(args.Error as TException);
            }
            else
            {
                OnCompleted(args);
            }
        }

        private void Rescue(TException exception)
        {
            var rescueResult = new SequentialResult(_rescue(exception).GetEnumerator());
            rescueResult.Completed += RescueCompleted;

            rescueResult.Execute(_context);
        }

        private void RescueCompleted(object sender, ResultCompletionEventArgs args)
        {
            (sender as IResult).Completed -= RescueCompleted;

            OnCompleted(new ResultCompletionEventArgs
                        {Error = args.Error, WasCancelled = args.WasCancelled || CancelResult});
        }
    }
}