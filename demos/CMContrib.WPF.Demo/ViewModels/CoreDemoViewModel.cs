using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Threading;
using Caliburn.Micro.Contrib.Demo.Results;
using Caliburn.Micro.Contrib.Filters;
using Caliburn.Micro.Contrib.Results;

namespace Caliburn.Micro.Contrib.Demo.ViewModels
{
    [Export(typeof(IDemo))]
    public class CoreDemoViewModel : Screen, IDemo
    {
        public CoreDemoViewModel()
        {
            DisplayName = "Core Demo";
        }

        public IEnumerable<IResult> Busy(int ms)
        {
            yield return new DelegateResult(() => LongRunningTask(ms))
                .OnWorkerThread("Processing...")
                .In<ShellView>();
        }

        [OnWorkerThread(Message = "Processing...", BusyIndicatorImplementation = typeof(ShellView))]
        public IEnumerable<IResult> BusyWithAttribute(int ms)
        {
            yield return new DelegateResult(() => LongRunningTask(ms));
        }

        [Rescue(MethodName = "GeneralRescue")]
        public IEnumerable<IResult> Catch()
        {
            yield return new DelegateResult(() =>
                                            {
                                                throw new Exception();
                                            });
        }

        public IEnumerable<IResult> Rescue()
        {
            var ex = new Exception("General Exception");
            var argEx = new ArgumentException("Specific Exception");

            yield return new ErrorResult(ex)
                    .Rescue().Execute(GeneralRescue, false);

            yield return new ErrorResult(argEx)
                    .Rescue<ArgumentException>().Execute(ArgumentRescue, false);

            yield return new ErrorResult(ex)
                    .Rescue().Invoke(RescueAction);
        }

        public IEnumerable<IResult> Cancel()
        {
            yield return new CancelResult()
               .WhenCancelled().Execute(ContinueCoroutine)
               .WhenCancelled().Override();

            yield return new CancelResult()
                .WhenCancelled().Invoke(ContinueAction);
        }

        private void LongRunningTask(int ms)
        {
            Thread.Sleep(ms);
        }

        public static IEnumerable<IResult> GeneralRescue(Exception e)
        {
            yield return new LogResult(string.Format("Rescued Exception of type \'{0}\' with coroutine", e.GetType()));
        }

        private static IEnumerable<IResult> ArgumentRescue(ArgumentException e)
        {
            yield return new LogResult("Rescued ArgumentException with coroutine");
        }

        private static void RescueAction(Exception e)
        {
            IoC.Get<IShell>().Log(string.Format("Rescued {0} with an action", e.GetType()));
        }

        private static void ContinueAction()
        {
            IoC.Get<IShell>().Log(string.Format("Continued with action"));
        }

        private static IEnumerable<IResult> ContinueCoroutine()
        {
            yield return new LogResult("Continued with a coroutine");
        }
    }
}