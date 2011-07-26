using System;
using System.Collections.Generic;
using System.Linq;
using Caliburn.Micro.Contrib.Results;

namespace Caliburn.Micro.Contrib.Filters
{
    /// <summary>
    ///   Shows a busy indicator to the user while the coroutine is executed. 
    ///   Also delegates the execution of the coroutine to the ThreadPool b/c the ui would block during the execution otherwise
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class BusyCoroutineAttribute : AsyncCoroutineAttribute
    {
        public string Message { get; set; }

        public BusyCoroutineAttribute()
        {
            Message = Localizer.GetString("DefaultBusyMessage");
        }

        public override IEnumerable<IResult> Decorate(IEnumerable<IResult> coroutine, ActionExecutionContext context)
        {
            yield return BusyResult.Show(Message);

            var async = base.Decorate(coroutine, context).Single();
            async.Completed += (sender, args) =>
                Coroutine.BeginExecute(new SingleResultEnumerator(BusyResult.Hide()), context);

            yield return async;
        }
    }
}