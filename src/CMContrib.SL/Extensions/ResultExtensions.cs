using System;
using System.Collections.Generic;
using System.Threading;
using Caliburn.Micro.Contrib.Decorators;
using Caliburn.Micro.Contrib.Helper;
using Caliburn.Micro.Contrib.Results;

namespace Caliburn.Micro.Contrib
{
    public static class ResultExtensions
    {
        /// <summary>
        ///   Returns an <see cref = "IEnumerable{IResult}" /> with one item, the result
        /// </summary>
        /// <param name = "result"></param>
        /// <returns></returns>
        public static IEnumerable<IResult> AsCoroutine(this IResult result)
        {
            yield return result;
        }

        /// <summary>
        ///   Adds a rescue for <typeparamref name = "TException" /> to the <paramref name = "result" />
        /// </summary>
        /// <typeparam name = "TException"></typeparam>
        /// <param name = "result"></param>
        /// <returns></returns>
        public static IExceptionHandler<TException> Rescue<TException>(this IResult result)
            where TException : Exception
        {
            return new RescueHandler<TException>(result);
        }

        /// <summary>
        ///   Adds a rescue for all exceptions to the <paramref name = "result" />
        /// </summary>
        /// <param name = "result"></param>
        /// <returns></returns>
        public static IExceptionHandler<Exception> Rescue(this IResult result)
        {
            return Rescue<Exception>(result);
        }

        /// <summary>
        ///   Adds behavior to the result which is executed when the <paramref name = "result" /> is cancelled
        /// </summary>
        /// <param name = "result"></param>
        /// <returns></returns>
        public static ICancelledHandler WhenCancelled(this IResult result)
        {
            return new CancelledHandler(result);
        }

        /// <summary>
        ///   Executes the result and waits for its completition. When completes, the <see cref = "ResultCompletionEventArgs" /> of the result are returned
        /// </summary>
        /// <param name = "result"></param>
        /// <param name = "context"></param>
        /// <returns></returns>
        internal static ResultCompletionEventArgs BlockingExecute(this IResult result,
                                                                ActionExecutionContext context = null)
        {
            var wait = new AutoResetEvent(false);

            ResultCompletionEventArgs args = null;
            result.Completed += (sender, eventArgs) =>
                                {
                                    args = eventArgs;
                                    wait.Set();
                                };

            result.Execute(context);

            wait.WaitOne();

            return args;
        }

        /// <summary>
        /// Executes the <paramref name="result"/> on a seperate worker thread
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static IResult OnWorkerThread(this IResult result)
        {
            return new AsyncResultDecorator(result);
        }

        /// <summary>
        /// Executes the <paramref name="result"/> on a seperate worker thread and shows a busy message during the execution
        /// </summary>
        /// <param name="result"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static IBusyResult OnWorkerThread(this IResult result, string message)
        {
            return new BusyResultDecorator(result, message);
        }

        #region IOpenResult<TChild>

        public static IOpenResult<TChild> BeforeActivationDo<TChild>(this IOpenResult<TChild> result,
                                                                     Func<TChild, IEnumerable<IResult>> coroutine)
        {
            result.BeforeActivation = coroutine;
            return result;
        }

        public static IOpenResult<TChild> AfterActivationDo<TChild>(this IOpenResult<TChild> result,
                                                                    Func<TChild, IEnumerable<IResult>> coroutine)
        {
            result.AfterActivation = coroutine;
            return result;
        }

        public static IOpenResult<TChild> BeforeClosingDo<TChild>(this IOpenResult<TChild> result,
                                                                  Func<TChild, IEnumerable<IResult>> coroutine)
        {
            result.BeforeClosing = coroutine;
            return result;
        }

        public static IOpenResult<TChild> AfterClosingDo<TChild>(this IOpenResult<TChild> result,
                                                                 Func<TChild, IEnumerable<IResult>> coroutine)
        {
            result.AfterClosing = coroutine;
            return result;
        }

        public static IOpenResult<TChild> BeforeActivationDo<TChild>(this IOpenResult<TChild> result,
                                                                     Action<TChild> action)
        {
            result.BeforeActivation = child => new DelegateResult(() => action(child)).AsCoroutine();
            return result;
        }

        public static IOpenResult<TChild> AfterActivationDo<TChild>(this IOpenResult<TChild> result,
                                                                    Action<TChild> action)
        {
            result.AfterActivation = child => new DelegateResult(() => action(child)).AsCoroutine();
            return result;
        }

        public static IOpenResult<TChild> BeforeClosingDo<TChild>(this IOpenResult<TChild> result, Action<TChild> action)
        {
            result.BeforeClosing = child => new DelegateResult(() => action(child)).AsCoroutine();
            return result;
        }

        public static IOpenResult<TChild> AfterClosingDo<TChild>(this IOpenResult<TChild> result, Action<TChild> action)
        {
            result.AfterClosing = child => new DelegateResult(() => action(child)).AsCoroutine();
            return result;
        }

        #endregion
    }
}