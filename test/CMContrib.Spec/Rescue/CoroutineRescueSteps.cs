using System;
using System.Collections.Generic;
using System.IO;
using Caliburn.Micro;
using Caliburn.Micro.Contrib;
using Moq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CMContrib.Spec.Rescue
{
    [Binding]
    public class CoroutineRescueSteps
    {
        public RescueContext Context { get; private set; }

        private IOException _rescueException = new IOException();
        private ResultCompletionEventArgs _rescueCompletedArgs;

        public CoroutineRescueSteps(RescueContext context)
        {
            Context = context;
        }

        [Given(@"I want to rescue all errors with a coroutine")]
        public void GivenIWantToRescueAllErrorsWithACoroutine()
        {
            Context.Result = Context.Result.CatchWithCoroutine(RescueCoroutine);
        }

        [Given(@"I want to rescue ArgumentException errors with a coroutine")]
        public void GivenIWantToRescueArgumentExceptionErrorsWithACoroutine()
        {
            Context.Result = Context.Result.CatchWithCoroutine<ArgumentException>(RescueCoroutine);
        }

        [Then(@"the rescue coroutine is invoked on the arbitrary exception")]
        public void ThenTheRescueCoroutineIsInvokedOnTheArbitraryException()
        {
            Assert.AreEqual(RescueContext.ArbitraryException, Context.RescuedException);
            Assert.IsTrue(Context.RescueInvoked);
        }

        public IEnumerable<IResult> RescueCoroutine(Exception ex)
        {
            return RescueCoroutine(ex, true, null);
        }

        [Then(@"the rescue coroutine is invoked on the ArgumentException")]
        public void ThenTheRescueCoroutineIsInvokedOnTheArgumentException()
        {
            Assert.IsTrue(Context.RescuedException is ArgumentException);
        }

        [Then(@"the rescue coroutine is not invoked")]
        public void ThenTheRescueCoroutineIsNotInvoked()
        {
            Assert.IsFalse(Context.RescueInvoked);
        }

        [Given(@"I want to rescue all errors with a coroutine that completes with an error")]
        public void GivenIWantToRescueAllErrorsWithACoroutineThatCompletesWithAnError()
        {
            Context.Result = Context.Result.CatchWithCoroutine(ex => RescueCoroutine(ex, false, _rescueException));
        }

        [Then(@"the result completes with the same error as the coroutine")]
        public void ThenTheResultCompletesWithTheSameErrorAsTheCoroutine()
        {
            Assert.AreEqual(_rescueException, Context.ResultCompletedArgs.Error);
        }

        public IEnumerable<IResult> RescueCoroutine(Exception ex, bool wasCancelled, Exception rescueException)
        {
            var rescueResultMock = new Mock<IResult>();

            Context.RescuedException = ex;

            //rescueResultMock.Setup(x => x.Execute(It.IsAny<ActionExecutionContext>()))
            //    .Callback(() => Context.RescueInvoked = true);

            rescueResultMock.Setup(x => x.Execute(It.IsAny<ActionExecutionContext>()))
                .Raises(x => x.Completed += null, () =>
                                                      {
                                                          Context.RescueInvoked = true;
                                                          return new ResultCompletionEventArgs
                                                                     {
                                                                         WasCancelled = wasCancelled,
                                                                         Error = rescueException
                                                                     };
                                                      });

            rescueResultMock.Object.Completed += (sender, args) => _rescueCompletedArgs = args;

            yield return rescueResultMock.Object;
        }
    }
}