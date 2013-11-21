using Caliburn.Micro;
using Caliburn.Micro.Contrib;
using NUnit.Framework;

namespace CMContrib.Test.Decorators.WorkerThread
{
    public class WorkerThreadResultDecorator_BaseFixture
    {
        [TestFixtureSetUp]
        public void FixtureSetUp()
        {
            IoC.BuildUp = x => { };
        }

        [TestFixtureTearDown]
        public void FixtureTearDown()
        {
            // ResultSynchronizationContext.Instance.Dispose();
        }
    }
}