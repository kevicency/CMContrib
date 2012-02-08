using System;
using System.Threading;
using Caliburn.Micro;
using Caliburn.Micro.Contrib;
using Caliburn.Micro.Contrib.Decorators;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.Busy
{
    [TestFixture]
    public class InnerResultIsCancelled : BusyResultDecorator_BaseFixture
    {
        [Test]
        public void BusyIndicatorIsSetToIdleAlthoughTheInnerResultIsCancelled()
        {
            BusyIndicatorMock.Setup(x => x.Idle())
                .Verifiable();

            var inner = TestHelper.MockResult(false, new Exception()).Object;
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