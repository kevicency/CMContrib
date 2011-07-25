using System.Collections.Generic;
using System.Linq;
using Caliburn.Micro.Contrib.Decorators;
using Caliburn.Micro.Contrib.Filters;

namespace Caliburn.Micro.Contrib
{
    public static class ActionExecutionContextExtensions
    {
        public static IEnumerable<IFilter> GetFilters(this ActionExecutionContext context)
        {
            return context.Target.GetType().GetAttributes<IFilter>(inherit: true)
                .Union(context.Method.GetAttributes<IFilter>(inherit: true))
                .OrderByDescending(x => x.Priority);
        }
    }
}