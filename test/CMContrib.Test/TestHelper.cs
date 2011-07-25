using System;
using System.Collections.Generic;
using System.Threading;
using Caliburn.Micro;
using Moq;

namespace CMContrib.Test
{
    public static class TestHelper
    {
        static TestHelper()
        {
            IoC.BuildUp = x => { };
        }

        public static IEnumerable<IResult> EmptyCoroutine
        {
            get { return new IResult[0]; }
        }

        public static IEnumerable<IResult> FailingCoroutine
        {
            get { return new IResult[0]; }
        }

        public static Mock<IResult> MockResult(bool wasCancelled, Exception error)
        {
            var mock = new Mock<IResult>();
            mock.Setup(x => x.Execute(It.IsAny<ActionExecutionContext>()))
                .Raises(x => x.Completed += null, new ResultCompletionEventArgs() { WasCancelled = wasCancelled, Error = error });

            return mock;
        }

        public static Mock<IResult> ThrowingResult(Exception exception)
        {
            var mock = new Mock<IResult>();
            mock.Setup(x => x.Execute(It.IsAny<ActionExecutionContext>()))
                .Throws(exception);

            return mock;
        }

        public static ResultCompletionEventArgs BlockingExecute(this IResult result, ActionExecutionContext context = null)
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
    }
}
