using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Threading;
using Caliburn.Micro.Contrib.Filters;
using Caliburn.Micro.Contrib.Results;
using Caliburn.Micro.Contrib.WPF.Demo.Results;

namespace Caliburn.Micro.Contrib.WPF.Demo.ViewModels
{
    [Export(typeof(IDemo))]
    public class CoreDemoViewModel : Screen, IDemo
    {
        public CoreDemoViewModel()
        {
            DisplayName = "Core Demo";
        }

        [BusyCoroutine]
        [CatchCoroutine(MethodName= "Rescue")]
        public IEnumerable<IResult> BusyAndThreadPool(int ms)
        {
            yield return new DelegateResult(() => LongRunningTask(ms));
        }

        public IEnumerable<IResult> ErrorCoroutine()
        {
            var error = new ArgumentException("Some error");

            yield return new ErrorResult(error)
                .Rescue<ArgumentException>().With(coroutine: RescueCoroutine);
        }

        public IEnumerable<IResult> CancelCoroutine()
        {
            yield return new CancelResult()
            .WhenCancelled().Execute(ContinueCoroutine());
        }

        public IEnumerable<IResult> CancelAction()
        {
            yield return new CancelResult()
                .WhenCancelled().Execute(ContinueAction);
        }

        public IEnumerable<IResult> ErrorAction()
        {
            var error = new ArgumentException("Some error");

            yield return new ErrorResult(error)
                .Rescue<ArgumentException>().With(ex => Console.WriteLine(ex.Message));
        }


        private void LongRunningTask(int ms)
        {
            Thread.Sleep(ms);
        }

        private static IEnumerable<IResult> RescueCoroutine(ArgumentException e)
        {
            yield return new LogResult(string.Format("Exception catched with Coroutine: {0} - {1}", e.GetType(), e.Message));
        }

        private static void RescueAction(Exception e)
        {
            IoC.Get<IShell>().Log(string.Format("Exception catched with Action: {0} - {1}", e.GetType(), e.Message));
        }

        private static IEnumerable<IResult> ContinueCoroutine()
        {
            yield return new LogResult(string.Format("Continued with coroutine"));
        }

        private static void ContinueAction()
        {
            IoC.Get<IShell>().Log(string.Format("Continued with action"));
        }
    }
}