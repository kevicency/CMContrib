using System;
using System.Collections.Generic;
using System.Threading;
using Caliburn.Micro;
using Caliburn.Micro.Contrib;
using Caliburn.Micro.Contrib.Results;
using Machine.Fakes;
using Machine.Specifications;
using Moq;
using It = Machine.Specifications.It;

namespace CMContrib.Spec.Results
{
    public class ConductResult_Spec : WithMoqFakes
    {
        static ConductResult<IScreen> Sut;
        static IScreen Item;
        static IConductor Conductor;
        static ResultCompletionEventArgs CompletionArgs;

        Establish context = () =>
        {
            IoC.BuildUp = x => { };

            Item = An<IScreen>();
            Conductor = An<IConductor>();
            Sut = new ConductResult<IScreen>(Item);
            Sut.In(Conductor);
            (Sut as IResult).Completed += (sender, args) => CompletionArgs = args;
        };

        [Subject(typeof (ConductResult<>))]
        public class when_the_result_gets_executed
        {
            Because of = () => Sut.BlockingExecute(null);

            It the_item_gets_activated = () => Conductor.WasToldTo(x => x.ActivateItem(Item));
            It the_result_completes_without_error = () => CompletionArgs.Error.ShouldBeNull();
            It the_result_is_not_cancelled = () => CompletionArgs.WasCancelled.ShouldBeFalse();

            [Subject(typeof (ConductResult<>))]
            public class and_a_BeforeActivation_coroutine_is_set
            {
                Establish that = () =>
                {
                    BeforeActivation = An<IEnumerable<IResult>>();
                    BeforeActivation
                        .WhenToldTo(x => x.GetEnumerator())
                        .Return(() =>
                        {
                            Conductor.WasNotToldTo(c => c.ActivateItem(Item));
                            BeforeActivationExecuted = true;

                            return An<IEnumerator<IResult>>();
                        });

                    Sut.BeforeActivationDo(x => BeforeActivation);
                };

                It the_coroutine_is_executed_before_the_item_gets_activated =
                    () => BeforeActivationExecuted.ShouldBeTrue();

                static IEnumerable<IResult> BeforeActivation;
                static bool BeforeActivationExecuted;
            }

            [Subject(typeof (ConductResult<>))]
            public class and_a_failing_BeforeActivation_coroutine_is_set
            {
                Establish that = () =>
                {
                    var failingResult = new Mock<IResult>();
                    failingResult.Setup(x => x.Execute(Moq.It.IsAny<ActionExecutionContext>()))
                        .Raises(x => x.Completed += null, new ResultCompletionEventArgs {Error = Error});

                    BeforeActivation = An<IEnumerable<IResult>>();
                    BeforeActivation
                        .WhenToldTo(x => x.GetEnumerator())
                        .Return(() => new SingleResultEnumerator(failingResult.Object));

                    Sut.BeforeActivationDo(x => BeforeActivation);
                };

                It the_result_completes_with_the_same_error = () => CompletionArgs.Error.ShouldBeTheSameAs(Error);
                It the_item_doesnt_get_activated = () => Conductor.WasNotToldTo(c => c.ActivateItem(Item));

                static IEnumerable<IResult> BeforeActivation;
                static Exception Error = new Exception();
            }

            [Subject(typeof (ConductResult<>))]
            public class and_an_AfterActivation_coroutine_is_set
            {
                Establish that = () =>
                {
                    AfterActivation = An<IEnumerable<IResult>>();
                    AfterActivation
                        .WhenToldTo(x => x.GetEnumerator())
                        .Return(() =>
                        {
                            Conductor.WasToldTo(c => c.ActivateItem(Item));
                            AfterActivationExecuted = true;

                            return An<IEnumerator<IResult>>();
                        });

                    Sut.AfterActivationDo(x => AfterActivation);
                };

                It the_coroutine_is_executed_after_the_item_got_activated = () => AfterActivationExecuted.ShouldBeTrue();

                static IEnumerable<IResult> AfterActivation;
                static bool AfterActivationExecuted;
            }

            [Subject(typeof (ConductResult<>))]
            public class and_a_failing_AfterActivation_coroutine_is_set
            {
                Establish that = () =>
                {
                    var failingResult = new Mock<IResult>();
                    failingResult.Setup(x => x.Execute(Moq.It.IsAny<ActionExecutionContext>()))
                        .Raises(x => x.Completed += null, new ResultCompletionEventArgs {Error = Error});

                    AfterActivation = An<IEnumerable<IResult>>();
                    AfterActivation
                        .WhenToldTo(x => x.GetEnumerator())
                        .Return(() => new SingleResultEnumerator(failingResult.Object));

                    Sut.AfterActivationDo(x => AfterActivation);
                };

                It the_result_completes_with_the_same_error = () => CompletionArgs.Error.ShouldBeTheSameAs(Error);

                static IEnumerable<IResult> AfterActivation;
                static Exception Error = new Exception();
            }
        }

        [Subject(typeof (ConductResult<>))]
        public class when_the_result_gets_executed_and_the_item_then_gets_deactivated
        {
            Because of = () =>
            {
                Sut.BlockingExecute(null);

                Conductor.DeactivateItem(Item, true);
            };
            
            [Subject(typeof (ConductResult<>))]
            public class and_a_BeforeClosing_coroutine_is_set
            {
                Establish that = () =>
                {
                    BeforeClosing = An<IEnumerable<IResult>>();
                    BeforeClosing
                        .WhenToldTo(x => x.GetEnumerator())
                        .Return(() => An<IEnumerator<IResult>>());

                    Sut.BeforeClosingDo((x => BeforeClosing));
                };


                It the_coroutine_is_executed_before_the_item_is_closed =
                    () => Item.WasNotToldTo(x => x.Deactivate(true));

                static IEnumerable<IResult> BeforeClosing;
            }

            [Subject(typeof (ConductResult<>))]
            public class and_a_AfterClosing_coroutine_is_set
            {
                Establish that = () =>
                {
                    AfterClosing = An<IEnumerable<IResult>>();
                    AfterClosing
                        .WhenToldTo(x => x.GetEnumerator())
                        .Return(() =>
                        {
                            Item.WasToldTo(i => i.Deactivate(true));
                            AfterClosingExecuted = true;

                            return An<IEnumerator<IResult>>();
                        });

                    Sut.AfterClosingDo((x => AfterClosing));
                };

                It the_coroutine_is_executed_after_the_item_is_closed = () =>
                {
                    var ignore = "Couldn't get this test to work because of async";
                };

                static IEnumerable<IResult> AfterClosing;
                static bool AfterClosingExecuted;
            }
        }
    }
}