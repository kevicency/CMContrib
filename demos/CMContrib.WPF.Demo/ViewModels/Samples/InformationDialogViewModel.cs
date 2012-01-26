using System.Collections.Generic;
using System.ComponentModel.Composition;
using Caliburn.Micro.Contrib.Demo.Results;
using Caliburn.Micro.Contrib.Dialogs;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof(ISample))]
    public class InformationDialogViewModel : DialogSampleScreen
    {
        public InformationDialogViewModel()
        {
            Description = "Special Dialog to provide the user with informations.";
        }

        public override IEnumerable<IResult> Execute()
        {
            var information = new Information(Properties.Demo.LoremIpsum,
                                              Answer.Ok);

            yield return information.AsResult();

            yield return LogResponse(information);
        }
    }
}