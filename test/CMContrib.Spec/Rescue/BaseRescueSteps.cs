using Caliburn.Micro;
using Moq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CMContrib.Spec.Rescue
{
    [Binding]
    public class BaseRescueSteps
    {
        public RescueContext Context { get; private set; }

        [Given(@"an arbitrary result which (.*)")]
        public void GivenAnArbitraryResultWhichCompletesWithoutErrors(ResultCompletionEventArgs args)
        {
            var resultMock = new Mock<IResult>();

            resultMock.Setup(x => x.Execute(It.IsAny<ActionExecutionContext>()))
                .Raises(x => x.Completed += null, args);

            Context.Result = resultMock.Object;
        }

        

        [Then(@"the result completes without an error")]
        public void ThenTheResultCompletesWithoutAnError()
        {
            Assert.IsNull(Context.ResultCompletedArgs.Error);
        }

        [Then(@"the result does not get cancelled")]
        public void ThenTheResultDoesNotGetCancelled()
        {
            Assert.IsFalse(Context.ResultCompletedArgs.WasCancelled);
        }

        [Then(@"the result gets cancelled")]
        public void ThenTheResultGetsCancelled()
        {
            Assert.IsTrue(Context.ResultCompletedArgs.WasCancelled);
        }

        [When(@"the result is executed")]
        public void WhenTheResultIsExecuted()
        {
            IResult result = Context.Result;

            result.Completed += (sender, args) => Context.ResultCompletedArgs = args;

            result.Execute(new ActionExecutionContext());
        }

        public BaseRescueSteps(RescueContext context)
        {
            Context = context;
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            IoC.BuildUp = o => { };
        }
    }
}