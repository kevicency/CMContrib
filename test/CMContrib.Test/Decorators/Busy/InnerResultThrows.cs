using System;
using System.Threading;
using Caliburn.Micro;
using Caliburn.Micro.Contrib.Decorators;
using Moq;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.Busy
{
    [TestFixture]
    public class InnerResultThrows : BusyResultDecorator_BaseFixture
    {
        [Test]
        public void BusyIndicatorGetsSetToIdle()
        {
            BusyIndicatorMock.Setup(x => x.Idle())
                  .Verifiable();

            var waitHandle = new ManualResetEvent(false);
            var inner = TestHelper.ThrowingResult(new Exception()).Object;
            var sut = new BusyResultDecorator(inner, "foo")
                .In(BusyIndicator);

            sut.Completed += (sender, args) => waitHandle.Set();

            sut.Execute(null);
            waitHandle.WaitOne(3000);

            BusyIndicatorMock.VerifyAll();
        }
    }
}