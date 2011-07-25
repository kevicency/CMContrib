using System;
using Caliburn.Micro;
using Caliburn.Micro.Contrib;
using Caliburn.Micro.Contrib.Decorators;
using Moq;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.ContinueCoroutine
{
    [TestFixture]
    public class InnerResultIsCancelled
    {
        IResult _inner;

        [SetUp]
        public void SetUp()
        {
            _inner = TestHelper.MockResult(true, null).Object;
        }

        [Test]
        public void CoroutineGetsExecuted()
        {
            bool coroutineExecuted = false;
            var resultMock = new Mock<IResult>();

            resultMock.Setup(x => x.Execute(It.IsAny<ActionExecutionContext>()))
                .Raises(x => x.Completed += null, () =>
                                                      {
                                                          coroutineExecuted = true;
                                                          return new ResultCompletionEventArgs();
                                                      });

            var sut = new ContinueResultDecorator(_inner, resultMock.Object.AsCoroutine());

            sut.BlockingExecute();

            Assert.IsTrue(coroutineExecuted);
        }

        [Test]
        public void CoroutineUsesSameContextAsInner()
        {
            var context = new ActionExecutionContext();
            var resultMock = new Mock<IResult>();
            resultMock.Setup(x => x.Execute(context))
                .Raises(x => x.Completed += null, new ResultCompletionEventArgs())
                .Verifiable("wrong context");

            var sut = new ContinueResultDecorator(_inner, resultMock.Object.AsCoroutine());

            sut.BlockingExecute(context);

            resultMock.Verify();
        }

        [Test]
        public void ResultIsStillCancelled()
        {
            var sut = new ContinueResultDecorator(_inner, TestHelper.EmptyCoroutine);

            var args = sut.BlockingExecute();

            Assert.IsTrue(args.WasCancelled);
        }

        [Test]
        public void DecoratorFailsWhenCoroutineFails()
        {
            var error = new Exception();
            var failingResult = TestHelper.MockResult(false, error).Object;

            var sut = new ContinueResultDecorator(_inner, failingResult.AsCoroutine());

            var args = sut.BlockingExecute();

            Assert.AreSame(args.Error, error);
        }
    }
}