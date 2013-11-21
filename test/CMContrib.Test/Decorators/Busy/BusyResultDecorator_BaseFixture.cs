using Caliburn.Micro;
using Caliburn.Micro.Contrib;
using Caliburn.Micro.Contrib.Decorators;
using Moq;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.Busy
{
    [TestFixture]
    public abstract class BusyResultDecorator_BaseFixture
    {
        public BusyResultDecorator Sut;
        
        public IBusyIndicator BusyIndicator { get { return BusyIndicatorMock.Object; } }
        public Mock<IBusyIndicator> BusyIndicatorMock { get; set; }

        [TestFixtureSetUp]
        public void FixtureSetUp()
        {
            IoC.BuildUp = x => { };
        }

        [SetUp]
        public void SetUp()
        {
            BusyIndicatorMock = new Mock<IBusyIndicator>();

        }

        [TestFixtureTearDown]
        public void FixtureTearDown()
        {
            //ResultSynchronizationContext.Instance.Dispose();
        }
    }
}