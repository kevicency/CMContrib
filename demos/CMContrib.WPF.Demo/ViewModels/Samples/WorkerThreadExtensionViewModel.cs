using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading;
using Caliburn.Micro.Contrib.Results;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof(ISample))]
    public class WorkerThreadExtensionViewModel : SampleScreen
    {
        const int SleepTime = 5000;

        public WorkerThreadExtensionViewModel()
        {
            Category = SampleCategory.Coroutine;
            Description = "The OnWorkerThread Extension Method can be used to decorate IResults. " +
                          "The decorator delegates the execution of the result to a dedicated worker thread. " +
                          "If a message is given, an IBusyIndicator is located and activated while the result is executed. " +
                          "The IBusyIndicator is located by traversing the VisualTree (default) or by passing a type that implements " +
                          "IBusyIndicator (gets resolved via IoC container) or by passing a concrete instance.";
        }

        public override IEnumerable<IResult> Execute()
        {
            yield return new DelegateResult(() => Thread.Sleep(SleepTime))
                .OnWorkerThread(string.Format("Sleeping for {0} seconds", SleepTime/1000));
                //.In<ShellView>(); optional, since the ShellView is a root node in the VisualTree
        }
    }
}
