using System;
using Caliburn.Micro;
using Caliburn.Micro.Contrib.Results;
using Machine.Specifications;
using Action = System.Action;

namespace CMContrib.Spec.Results
{
    [Subject(typeof (DelegateResult))]
    public class DelegateResult_Spec
    {
        static ResultCompletionEventArgs CompletionArgs;

        protected static void CreateSut(Action action)
        {
            Sut = new DelegateResult(action);
            Sut.Completed += (sender, args) => CompletionArgs = args;
        }

        static DelegateResult Sut;

        [Subject(typeof (DelegateResult), "when executed")]
        public class with_fail_action
        {
            Establish that = () => CreateSut(FailAction);

            Because of = () => Catch.Exception(() => Sut.Execute(null));

            It completes_with_error = () => CompletionArgs.Error.ShouldBeTheSameAs(ThrownException);
            It doesnt_rethrow_the_exception = () => CatchedException.ShouldBeNull();

            static Exception CatchedException;
            static Action FailAction = () => { throw ThrownException; };
            static Exception ThrownException = new Exception();
        }

        [Subject(typeof (DelegateResult), "when executed")]
        public class with_success_action
        {
            Establish that = () => CreateSut(SuccessAction);

            Because of = () => Sut.Execute(null);

            It completes_without_error = () => CompletionArgs.Error.ShouldBeNull();
            It isnt_cancelled = () => CompletionArgs.WasCancelled.ShouldBeFalse();
            It invokes_the_action = () => Invoked.ShouldBeTrue();

            static bool Invoked;
            static Action SuccessAction = () => { Invoked = true; };
        }
    }
}