using System;
using System.Collections.Generic;
using Caliburn.Micro;
using Caliburn.Micro.Contrib.Decorators;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.Rescue
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
        public void ResultStillCompletes()
        {
            var sut = new RescueResultDecorator(_inner, ex => TestHelper.EmptyCoroutine, true);

            var args = sut.BlockingExecute();

            Assert.IsFalse(args.WasCancelled);
            Assert.IsNull(args.Error);
        }

        [Test]
        public void RescueIsNotExecuted()
        {
            bool rescueExecuted = false;

            Func<Exception, IEnumerable<IResult>> rescue = ex =>
                                                               {
                                                                   rescueExecuted = true;
                                                                   return TestHelper.EmptyCoroutine;
                                                               };

            var sut = new RescueResultDecorator(_inner, rescue, true);

            sut.BlockingExecute();

            Assert.IsFalse(rescueExecuted);
        }
    }
}