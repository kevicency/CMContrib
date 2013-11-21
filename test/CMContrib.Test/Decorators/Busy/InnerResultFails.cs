using System;
using System.Threading;
using Caliburn.Micro;
using Caliburn.Micro.Contrib.Decorators;
using Caliburn.Micro.Contrib.Results;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.Busy
{
    [TestFixture]
    public class InnerResultFails : BusyResultDecorator_BaseFixture
    {
        [Test]
        public void BusyIndicatorIsSetToIdleAlthoughTheInnerResultFails()
        {
            BusyIndicatorMock.Setup(x => x.Idle())
                .Verifiable();

            IResult inner = TestHelper.MockResult(false, new Exception()).Object;
            IBusyResult sut = new BusyResultDecorator(inner, "foo")
                .In(BusyIndicator);
            var waitHandle = new ManualResetEvent(false);
            sut.Completed += (sender, args) => waitHandle.Set();

            sut.Execute(null);
            waitHandle.WaitOne(3000);

            BusyIndicatorMock.VerifyAll();
        }
    }
}