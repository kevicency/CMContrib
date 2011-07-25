using System.Collections.Generic;

namespace Caliburn.Micro.Contrib.Helper
{
    public interface ICancelledHandler
    {
        /// <summary>
        ///   Executes an <paramref name = "action" /> when the result was cancelled
        /// </summary>
        /// <param name = "action"></param>
        /// <returns></returns>
        IResult Execute(System.Action action);

        /// <summary>
        ///   Executes a <paramref name = "coroutine" /> when the result was cancelled
        /// </summary>
        /// <param name = "coroutine"></param>
        /// <returns></returns>
        IResult Execute(IEnumerable<IResult> coroutine);
    }
}