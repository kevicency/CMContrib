using System.Threading;
using Caliburn.Micro;
using Caliburn.Micro.Contrib;
using Caliburn.Micro.Contrib.Decorators;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.WorkerThread
{
    [TestFixture]
    public class InnerResultIsCancelled : WorkerThreadResultDecorator_BaseFixture
    {
        [Test]
        public void DecoratorFailsWithSameError()
        {
            var waitHandle = new ManualResetEvent(false);
            var inner = TestHelper.MockResult(true, null).Object;
            var sut = new WorkerThreadResultDecorator(inner);

            sut.Completed += (sender, args) =>
            {
                Assert.IsTrue(args.WasCancelled);
                waitHandle.Set();
            };

            sut.Execute(null);
            waitHandle.WaitOne(3000);
        }
    }
}