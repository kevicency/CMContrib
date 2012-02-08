using System.Collections.Generic;
using System.ComponentModel.Composition;
using Caliburn.Micro.Contrib.Dialogs;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof(ISample))]
    public class ErrorDialogViewModel : DialogSampleScreen
    {
        public ErrorDialogViewModel()
        {
            Description = "Special Dialog to inform the user of an error.";
        }

        public override IEnumerable<IResult> Execute()
        {
            var error = new Error("Custom Error Title", Properties.Demo.LoremIpsum, Answer.Ok);

            yield return error.AsResult();

            yield return LogResponse(error);
        }
    }
}