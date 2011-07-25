using System;
using System.Collections.Generic;
using Caliburn.Micro;
using Caliburn.Micro.Contrib.Decorators;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.RescueCoroutine
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
        public void ResultIsStillCancelled()
        {
            var sut = new RescueResultDecorator(_inner, ex => TestHelper.EmptyCoroutine, true);

            var args = sut.BlockingExecute();

            Assert.IsTrue(args.WasCancelled);
            Assert.IsNull(args.Error);
        }

        [Test]
        public void RescueIsNotExecuted()
        {
            bool rescueInvoked = false;

            Func<Exception, IEnumerable<IResult>> rescue = ex =>
                                                               {
                                                                   rescueInvoked = true;
                                                                   return TestHelper.EmptyCoroutine;
                                                               };

            var sut = new RescueResultDecorator(_inner, rescue, true);

            sut.BlockingExecute();

            Assert.IsFalse(rescueInvoked);
        }
    }
}