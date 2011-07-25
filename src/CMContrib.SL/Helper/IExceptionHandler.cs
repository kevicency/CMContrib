using System;
using System.Collections.Generic;

namespace Caliburn.Micro.Contrib.Helper
{
    public interface IExceptionHandler<T>
        where T : Exception
    {
        /// <summary>
        ///   Invokes an <paramref name = "action" /> as a rescue
        /// </summary>
        /// <param name = "action"></param>
        /// <param name = "cancelResult">when TRUE the result will be cancelled</param>
        /// <returns></returns>
        IResult With(Action<T> action, bool cancelResult = true);

        /// <summary>
        ///   Executes a <paramref name = "cancelResult" /> as a rescue
        /// </summary>
        /// <param name = "coroutine"></param>
        /// <param name = "cancelResult">when TRUE the result will be cancelled</param>
        /// <returns></returns>
        IResult With(Func<T, IEnumerable<IResult>> coroutine, bool cancelResult = true);
    }
}