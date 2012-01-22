using System;
using System.Collections.Generic;
using Caliburn.Micro.Contrib.Decorators;

namespace Caliburn.Micro.Contrib.Filters
{
    /// <summary>
    ///   Delegates the execution of the coroutine the worker thread. Activates the IBusyIndicator when a message is given
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class OnWorkerThreadAttribute : DecorateCoroutineAttribute
    {   
        public string Message { get; set; }
        public Type BusyIndicatorImplementation { get; set; }

        public OnWorkerThreadAttribute()
        {
            Message = Localizer.GetString("DefaultBusyMessage");
        }

        public override IEnumerable<IResult> Decorate(IEnumerable<IResult> coroutine, ActionExecutionContext context)
        {
            var inner = new SequentialResult(coroutine.GetEnumerator());
          
            if (!String.IsNullOrWhiteSpace(Message))
            {
                var busyDecorator = new BusyResultDecorator(inner, Message);
                if (BusyIndicatorImplementation != null)
                {
                    busyDecorator.In(BusyIndicatorImplementation);
                }

                yield return busyDecorator;
            }
            else
            {
                yield return new AsyncResultDecorator(inner);
            }
        }
    }
}