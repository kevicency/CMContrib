using System.Collections.Generic;

namespace Caliburn.Micro.Contrib.Filters
{
    public interface IDecorateCoroutineFilter : IFilter
    {
        IEnumerable<IResult> Decorate(IEnumerable<IResult> coroutine, ActionExecutionContext context);
    }
}