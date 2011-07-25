using System.Collections.Generic;
using Caliburn.Micro.Contrib.Results;

namespace Caliburn.Micro.Contrib.Filters
{
    /// <summary>
    ///   Shows a busy indicator to the user while the coroutine is executed. 
    ///   Also delegates the execution of the coroutine to the ThreadPool b/c the ui would block during the execution otherwise
    /// </summary>
    public class BusyCoroutineAttribute : AsyncCoroutineAttribute
    {
        public string Message { get; set; }

        public override IEnumerable<IResult> Decorate(IEnumerable<IResult> coroutine, ActionExecutionContext context)
        {
            yield return BusyResult.Show(Message);

            foreach (var result in base.Decorate(coroutine, context))
            {
                yield return result;
            }

            yield return BusyResult.Hide();
        }
    }
}