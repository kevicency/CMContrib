using Caliburn.Micro;
using Caliburn.Micro.Contrib.Decorators;
using NUnit.Framework;

namespace CMContrib.Test.Decorators
{
    [TestFixture]
    public class ResultDecoratorBase_Fixture
    {
        [Test]
        public void InnerResult_IsBuiltUpByContainer()
        {
            var isBuiltUp = false;

            var innerMock = TestHelper.MockResult(false, null);

            var sut = new ResultDecoratorBase(innerMock.Object);
            IoC.BuildUp = x => isBuiltUp = ReferenceEquals(x, sut.Inner);
            sut.Execute(null);

            Assert.IsTrue(isBuiltUp);
        }
    }
}
