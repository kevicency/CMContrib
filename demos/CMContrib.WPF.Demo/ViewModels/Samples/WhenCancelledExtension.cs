using System.Collections.Generic;
using System.ComponentModel.Composition;
using Caliburn.Micro.Contrib.Demo.Results;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof(ISample))]
    public class WhenCancelledExtension : SampleScreen
    {
        public WhenCancelledExtension()
        {
            Category = SampleCategory.Core;
            Description = "The WhenCancelled Extension Method can be used to decorate IResults. " +
                          "The decorator either takes a coroutine or action that is invoked when the result is cancelled. " +
                          "It is also possible to override the cancel of an IResult";
        }

        public override IEnumerable<IResult> Execute()
        {
            yield return new CancelResult()
                .WhenCancelled().Execute(new LogResult("Continued with a coroutine").AsCoroutine)
                .WhenCancelled().Override();

            yield return new CancelResult()
                .WhenCancelled().Invoke(() => IoC.Get<IShell>().Log("Continued with an Action"));
        }
    }
}