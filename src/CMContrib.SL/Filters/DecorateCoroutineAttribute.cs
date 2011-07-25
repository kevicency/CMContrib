using System;
using System.Collections.Generic;

namespace Caliburn.Micro.Contrib.Filters
{
    public abstract class DecorateCoroutineAttribute : Attribute, IDecorateCoroutineFilter
    {
        public int Priority { get; set; }

        public abstract IEnumerable<IResult> Decorate(IEnumerable<IResult> coroutine, ActionExecutionContext context);
    }
}