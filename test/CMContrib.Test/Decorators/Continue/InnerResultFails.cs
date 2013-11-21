using System;
using System.Collections.Generic;
using Caliburn.Micro;
using Caliburn.Micro.Contrib;
using Caliburn.Micro.Contrib.Decorators;
using Moq;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.Continue
{
    [TestFixture]
    public class InnerResultFails
    {
        private readonly Exception _innerError = new Exception();
        IResult _inner;

        [SetUp]
        public void SetUp()
        {
            _inner = TestHelper.MockResult(false, _innerError).Object;
        }

        [Test]
        public void CoroutineDoesNotGetExecuted()
        {
            bool coroutineExecuted = false;
            var coroutineMock = new Mock<IResult>();
            coroutineMock.Setup(x => x.Execute(It.IsAny<ActionExecutionContext>()))
                .Callback(() => coroutineExecuted = true);

            var sut = new ContinueResultDecorator(_inner, () => coroutineMock.Object.AsEnumerable());

            sut.BlockingExecute();

            Assert.IsFalse(coroutineExecuted);
        }

        [Test]
        public void CoroutineIsNotEnumerated()
        {
            bool coroutineEnumerated = false;
            var coroutineMock = new Mock<IEnumerable<IResult>>();
            coroutineMock.Setup(x => x.GetEnumerator())
                .Callback(() => coroutineEnumerated = true);

            var sut = new ContinueResultDecorator(_inner, () => coroutineMock.Object);

            sut.BlockingExecute();

            Assert.IsFalse(coroutineEnumerated);
        }

        [Test]
        public void ResultStillFailsWithSameError()
        {
            var sut = new ContinueResultDecorator(_inner, () => TestHelper.EmptyCoroutine);

            var args = sut.BlockingExecute();

            Assert.AreSame(_innerError, args.Error);
        }
    }
}