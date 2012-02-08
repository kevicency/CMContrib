using System.Threading;
using Caliburn.Micro;
using Caliburn.Micro.Contrib;
using Caliburn.Micro.Contrib.Decorators;
using Caliburn.Micro.Contrib.Results;
using Moq;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.WorkerThread
{
    [TestFixture]
    public class InnerResultCompletes : WorkerThreadResultDecorator_BaseFixture
    {
        [Test]
        public void DecoratorDoesntCompleteOnWorkerThreadWhenContextIsGiven()
        {
            var waitHandle = new ManualResetEvent(false);
            var sendInvoked = false;
            var contextMock = new Mock<SynchronizationContext>();
            contextMock.Setup(x => x.Send(It.IsAny<SendOrPostCallback>(), It.IsAny<object>()))
                .Callback<SendOrPostCallback, object>((cb, args) =>
                {
                    Assert.IsInstanceOf<ResultCompletionEventArgs>(args);
                    sendInvoked = true;
                    waitHandle.Set();
                });
            SynchronizationContext.SetSynchronizationContext(contextMock.Object);

            var inner = new DelegateResult(() => { });
            var sut = new WorkerThreadResultDecorator(inner);

            sut.Execute(null);
            waitHandle.WaitOne(3000);

            Assert.IsTrue(sendInvoked);
        }

        [Test]
        public void InnerResultIsExecutedOnWorkerThread()
        {
            int threadId = Thread.CurrentThread.ManagedThreadId;
            var waitHandle = new ManualResetEvent(false);
            int? innerThreadId = null;

            var inner = new DelegateResult(() =>
            {
                innerThreadId = Thread.CurrentThread.ManagedThreadId;
                waitHandle.Set();
            });

            var sut = new WorkerThreadResultDecorator(inner);

            sut.Execute(null);
            waitHandle.WaitOne(3000);

            Assert.IsNotNull(innerThreadId);
            Assert.AreNotEqual(threadId, innerThreadId.Value);
        }
    }
}