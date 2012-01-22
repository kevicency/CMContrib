using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Caliburn.Micro.Contrib.Decorators
{
    /// <summary>
    ///   A result decorator which delegates the execution of the inner result to the thread pool
    /// </summary>
    public class AsyncResultDecorator : IResult
    {
        static readonly ILog _log = LogManager.GetLog(typeof (AsyncResultDecorator));
        readonly IResult _inner;

        public AsyncResultDecorator(IResult inner)
        {
            if (inner == null) throw new ArgumentNullException("inner");

            _inner = inner;
        }

        public static ResultSynchronizationContext ResultSyncContext
        {
            get { return ResultSynchronizationContext.Instance; }
        }

        public void Execute(ActionExecutionContext context)
        {
            var callContext = SynchronizationContext.Current;

            var task = new ResultExecutionTask(_inner, context);
            SendOrPostCallback callback = x =>
            {
                var args = (x as ResultExecutionTask).CompletionEventArgs;
                if (callContext != null)
                {
                    callContext.Send(y => Completed(this, y as ResultCompletionEventArgs), args);
                }
                else
                {
                    Completed(this, args);
                }
            };

            ResultSyncContext.Post(callback, task);
        }

        protected virtual void Before(ActionExecutionContext context){}
        protected virtual void After(ActionExecutionContext context){}

        public event EventHandler<ResultCompletionEventArgs> Completed = delegate { };
    }
}