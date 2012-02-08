using System;
using System.IO;
using Caliburn.Micro;
using Caliburn.Micro.Contrib.Decorators;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.Rescue
{
    [TestFixture]
    public class InnerResultThrows
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _inner = TestHelper.ThrowingResult(_error).Object;
        }

        #endregion

        private readonly ArgumentException _error = new ArgumentException();
        IResult _inner;


        [Test]
        public void RescueSpecific_IgnoresOtherThrownExceptions()
        {
            var sut = new RescueResultDecorator<IOException>(_inner, ex => TestHelper.EmptyCoroutine, true);

            var args = sut.BlockingExecute();

            Assert.AreSame(_error, args.Error);
        }

        [Test]
        public void RescueSpecific_RescuesSpecificThrownException()
        {
            var sut = new RescueResultDecorator<ArgumentException>(_inner, ex => TestHelper.EmptyCoroutine, true);

            var args = sut.BlockingExecute();

            Assert.IsNull(args.Error);
        }

        [Test]
        public void Rescue_RescuesAllThrownExceptions()
        {
            var sut = new RescueResultDecorator(_inner, ex => TestHelper.EmptyCoroutine, true);

            var args = sut.BlockingExecute();

            Assert.IsNull(args.Error);
        }
    }
}