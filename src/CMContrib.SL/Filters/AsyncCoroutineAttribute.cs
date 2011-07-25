using System.Collections.Generic;
using Caliburn.Micro.Contrib.Decorators;

namespace Caliburn.Micro.Contrib.Filters
{
    /// <summary>
    ///   Delegates the execution of the coroutine to the thread pool
    /// </summary>
    public class AsyncCoroutineAttribute : DecorateCoroutineAttribute
    {
        public override IEnumerable<IResult> Decorate(IEnumerable<IResult> coroutine, ActionExecutionContext context)
        {
            var sequentialResult = new SequentialResult(coroutine.GetEnumerator());

            yield return new AsyncResultDecorator(sequentialResult);
        }
    }
}