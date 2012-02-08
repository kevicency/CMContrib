using System;
using System.Threading;
using Caliburn.Micro;
using Caliburn.Micro.Contrib.Decorators;
using Caliburn.Micro.Contrib.Results;
using Moq;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.Busy
{
    [TestFixture]
    public class InnerResultCompletes : BusyResultDecorator_BaseFixture
    {
        [Test]
        public void BusyIndicatorIsSetToBusyBeforeTheInnerResultGetsExecuted()
        {
            bool isInnerExecuted = false;

            BusyIndicatorMock.Setup(x => x.Busy(It.IsAny<string>()))
                .Callback(() => Assert.IsFalse(isInnerExecuted, "BusyIndicator set busy to busy after inner result was executed"));

            var inner = new DelegateResult(() => isInnerExecuted = true);
            var sut = new BusyResultDecorator(inner, "foo")
                .In(BusyIndicator);

            sut.Execute(null);

            BusyIndicatorMock.VerifyAll();
        }

        [Test]
        public void BusyIndicatorIsSetToIdleAfterTheInnerResultCompleted()
        {
            bool isInnerCompleted = false;

            BusyIndicatorMock.Setup(x => x.Idle())
                .Callback(() => Assert.IsTrue(isInnerCompleted, "BusyIndicator set busy to idle before inner result completed"));

            var inner = new DelegateResult(() => { });
            inner.Completed += (sender, args) => { isInnerCompleted = true; };
            var sut = new BusyResultDecorator(inner, "foo")
                .In(BusyIndicator);
            var waitHandle = new ManualResetEvent(false);
            sut.Completed += (sender, args) => waitHandle.Set();

            sut.Execute(null);
            waitHandle.WaitOne(3000);

            BusyIndicatorMock.VerifyAll();
        }
    }
}