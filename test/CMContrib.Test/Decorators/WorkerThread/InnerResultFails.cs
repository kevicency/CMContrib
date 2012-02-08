using System;
using System.Threading;
using Caliburn.Micro;
using Caliburn.Micro.Contrib.Decorators;
using Moq;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.WorkerThread
{
    [TestFixture]
    public class InnerResultFails : WorkerThreadResultDecorator_BaseFixture
    {
        [Test]
        public void DecoratorFailsWithSameError()
        {
            var waitHandle = new ManualResetEvent(false);
            var error = new Exception("foo");
            var inner = TestHelper.MockResult(false, error).Object;
            var sut = new WorkerThreadResultDecorator(inner);

            sut.Completed += (sender, args) =>
            {
                Assert.AreSame(error, args.Error);
                waitHandle.Set();
            };
        

            sut.Execute(null);
            waitHandle.WaitOne(3000);
        }
    }
}