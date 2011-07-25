using System;
using System.Collections.Generic;
using System.IO;
using Caliburn.Micro;
using Caliburn.Micro.Contrib;
using Caliburn.Micro.Contrib.Decorators;
using Caliburn.Micro.Contrib.Results;
using Moq;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.RescueCoroutine
{
    [TestFixture]
    public class InnerResultFails
    {
        private readonly ArgumentException _error = new ArgumentException();
        IResult _inner;

        [SetUp]
        public void SetUp()
        {
            _inner = TestHelper.MockResult(false, _error).Object;
        }

        [Test]
        public void ResultIsCancelled()
        {
            var sut = new RescueResultDecorator(_inner, ex => TestHelper.EmptyCoroutine, true);

            var args = sut.BlockingExecute();

            Assert.IsTrue(args.WasCancelled);
        }

        [Test]
        public void ResultFailsWhenRescueFails()
        {
            var rescueError = new Exception();

            var sut = new RescueResultDecorator(_inner, ex => TestHelper.MockResult(false, rescueError).Object.AsCoroutine(), true);

            var args = sut.BlockingExecute();

            Assert.AreSame(rescueError, args.Error);
        }

        [Test]
        public void ResultFailsWhenRescueThrows()
        {
            var thrownException = new Exception();

            var sut = new RescueResultDecorator(_inner, ex => { throw thrownException; }, true);

            var args = sut.BlockingExecute();

            Assert.AreSame(thrownException, args.Error);
        }

        [Test]
        public void Rescue_RescuesAllErrors()
        {
            var sut = new RescueResultDecorator(_inner, ex => TestHelper.EmptyCoroutine, true);

            var args = sut.BlockingExecute();

            Assert.IsNull(args.Error);
        }

        [Test]
        public void RescueCoroutineIsExecuted()
        {
            Exception rescuedError = null;

            Func<Exception, IEnumerable<IResult>> handler = ex => new DelegateResult(() => rescuedError = ex).AsCoroutine();

            var sut = new RescueResultDecorator(_inner, handler, true);

            sut.BlockingExecute();

            Assert.AreSame(_error, rescuedError);
        }

        [Test]
        public void RescueCoroutineIsExecutedOnSameContext()
        {
            var _context = new ActionExecutionContext();

            var resultMock = new Mock<IResult>();
            resultMock.Setup(x => x.Execute(_context))
                .Verifiable();

            Func<Exception, IEnumerable<IResult>> handler = ex => resultMock.Object.AsCoroutine();

            var sut = new RescueResultDecorator(_inner, handler, true);

            sut.Execute(_context);

            resultMock.Verify();
        }

        [Test]
        public void RescueSpecific_RescuesSpecificErrors()
        {
            var sut = new RescueResultDecorator<ArgumentException>(_inner, ex => TestHelper.EmptyCoroutine, true);

            var args = sut.BlockingExecute();

            Assert.IsNull(args.Error);
        }

        [Test]
        public void RescueSpecific_NotRescuesOtherErrors()
        {
            var sut = new RescueResultDecorator<IOException>(_inner, ex => TestHelper.EmptyCoroutine, true);

            var args = sut.BlockingExecute();

            Assert.AreSame(_error, args.Error);
        }
    }
}