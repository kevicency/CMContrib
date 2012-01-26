using System.Collections.Generic;
using System.ComponentModel.Composition;
using Caliburn.Micro.Contrib.Demo.Results;
using Caliburn.Micro.Contrib.Dialogs;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof (ISample))]
    public class WarningDialogViewModel : DialogSampleScreen
    {
        public WarningDialogViewModel()
        {
            Description = "Special Dialog to show a warning to the user";
        }

        public override IEnumerable<IResult> Execute()
        {
            bool retry = true;
            while (retry)
            {
                var warning = new Warning(Properties.Demo.LoremIpsum,
                                          Answer.Retry,
                                          Answer.Ignore,
                                          Answer.Abort);

                yield return warning.AsResult()
                    .CancelOnResponse(Answer.Abort)
                    .WhenCancelled().Invoke(() => retry = false)
                    .WhenCancelled().Execute(new LogResult("Aborted").AsCoroutine);

                retry = warning.GivenResponse == Answer.Retry;

                yield return LogResponse(warning);
            }

        }
    }
}