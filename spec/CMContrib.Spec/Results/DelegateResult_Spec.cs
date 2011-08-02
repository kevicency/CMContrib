using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using Caliburn.Micro.Contrib.Results;
using Machine.Specifications;
using Action = System.Action;

namespace CMContrib.Spec.Results
{
    [Subject(typeof(DelegateResult))]
    public class DelegateResult_Spec
    {
        static DelegateResult Sut;
        static ResultCompletionEventArgs CompletionArgs;

        protected static void CreateSut(Action action)
        {
            Sut = new DelegateResult(action);
            Sut.Completed += (sender, args) => CompletionArgs = args;
        }

        [Subject(typeof (DelegateResult), "when executed")]
        public class with_fail_action
        {
            static Action FailAction = () => { throw ThrownException; };
            static Exception ThrownException = new Exception();
            static Exception CatchedException = null;

            Establish that = () => CreateSut(FailAction);

            Because of = () => Catch.Exception(() => Sut.Execute(null));

            It completes_with_error = () => CompletionArgs.Error.ShouldBeTheSameAs(ThrownException);
            It doesnt_throw_an_exception = () => CatchedException.ShouldBeNull();
        }

        [Subject(typeof(DelegateResult), "when executed")]
        public class with_success_action
        {
            static Action SuccessAction = () => { Invoked = true; };
            static bool Invoked;

            Establish that = () => CreateSut(SuccessAction);

            Because of = () => Sut.Execute(null);

            It completes_without_error = () => CompletionArgs.Error.ShouldBeNull();
            It isnt_cancelled = () => CompletionArgs.WasCancelled.ShouldBeFalse();
            It invokes_the_action = () => Invoked.ShouldBeTrue();
        }
    }
}
