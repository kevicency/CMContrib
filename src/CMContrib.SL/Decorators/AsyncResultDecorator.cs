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
    ///   A result decorator which delegates the execution of the inner result to a dedicated worker thread
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

            // Wrap the inner result in a SequentialResult s.t. it gets injected by the container but avoid deep nesting
            var wrapper = (_inner is SequentialResult || _inner is ResultDecoratorBase)
                              ? _inner
                              : new SequentialResult(new SingleResultEnumerator(_inner));

            var task = new ResultExecutionTask(wrapper, context);
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

        public event EventHandler<ResultCompletionEventArgs> Completed = delegate { };
    }
}