using System.Collections.Generic;
using Caliburn.Micro;
using Caliburn.Micro.Contrib.Decorators;
using Moq;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.ContinueCoroutine
{
    [TestFixture]
    public class InnerResultCompletes
    {
        IResult _inner;

        [SetUp]
        public void SetUp()
        {
            _inner = TestHelper.MockResult(false, null).Object;
        }

        [Test]
        public void CoroutineIsExecuted()
        {
            bool coroutineExecuted = false;
            var coroutineMock = new Mock<IEnumerable<IResult>>();
            coroutineMock.Setup(x => x.GetEnumerator())
                .Callback(() => coroutineExecuted = true);

            var sut = new ContinueResultDecorator(_inner, () => coroutineMock.Object);

            sut.BlockingExecute();

            Assert.IsFalse(coroutineExecuted);
        }

        [Test]
        public void ResultStillCompletes()
        {
            var sut = new ContinueResultDecorator(_inner, () => TestHelper.EmptyCoroutine);

            var args = sut.BlockingExecute();

            Assert.IsFalse(args.WasCancelled);
        }
    }
}