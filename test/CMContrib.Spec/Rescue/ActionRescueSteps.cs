using System;
using Caliburn.Micro.Contrib;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CMContrib.Spec.Rescue
{
    [Binding]
    public class ActionRescueSteps
    {
        public RescueContext Context { get; private set; }

        [Given(@"I want to rescue all errors with an action")]
        public void GivenIWantToRescueAllErrorsWithAnAction()
        {
            Context.Result = Context.Result.CatchWithAction(RescueAction);
        }

        [Given(@"I want to rescue ArgumentException errors with an action")]
        public void GivenIWantToRescueArgumentExceptionErrorsWithAnAction()
        {
            Context.Result = Context.Result.CatchWithAction<ArgumentException>(RescueAction);
        }

        [Then(@"the rescue action is invoked on the arbitrary exception")]
        public void ThenTheRescueActionIsInvokedOnTheArbitraryException()
        {
            Assert.IsNotNull(Context.RescuedException);
        }

        [Then(@"the rescue action is invoked on the ArgumentException")]
        public void ThenTheRescueActionIsInvokedOnTheArgumentException()
        {
            Assert.IsNotNull(Context.RescuedException);
            Assert.IsTrue(Context.RescuedException is ArgumentException);
        }

        [Then(@"the rescue action is not invoked")]
        public void ThenTheRescueActionIsNotInvoked()
        {
            Assert.IsFalse(Context.RescueInvoked);
        }

        public ActionRescueSteps(RescueContext context)
        {
            Context = context;
        }

        public void RescueAction(Exception ex)
        {
            Context.RescuedException = ex;
            Context.RescueInvoked = true;
        }
    }
}