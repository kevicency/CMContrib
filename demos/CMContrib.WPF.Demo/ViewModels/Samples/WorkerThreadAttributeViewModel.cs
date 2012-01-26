using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Threading;
using Caliburn.Micro.Contrib.Filters;
using Caliburn.Micro.Contrib.Results;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof(ISample))]
    public class WorkerThreadAttributeViewModel : SampleScreen
    {
        const int SleepTime = 5000;

        public WorkerThreadAttributeViewModel()
        {
            Category = SampleCategory.Core;
            Description =
                "The OnWorkerThread Attribute Method can be used to decorate methods that return a coroutine. " +
                "The decorator delegates the execution of the coroutine to a dedicated worker thread. " +
                "If a message is given, an IBusyIndicator is located and activated while the coroutine is executed. " +
                "The IBusyIndicator is located by traversing the VisualTree (default) or by passing a type that implements " +
                "IBusyIndicator (gets resolved via IoC container).";
        }

        [OnWorkerThread(Message = "Sleeping for 5 seconds...")]
        public override IEnumerable<IResult> Execute()
        {
            yield return new DelegateResult(() => Thread.Sleep(SleepTime));
        }
    }
}