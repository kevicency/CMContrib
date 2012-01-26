using Caliburn.Micro.Contrib.Demo.Results;
using Caliburn.Micro.Contrib.Dialogs;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    public abstract class DialogSampleScreen : SampleScreen
    {
        public DialogSampleScreen()
        {
            Category = SampleCategory.Dialogs;
        }

        public IResult LogResponse(Dialog dialog)
        {
            return new LogResult("You responded with {0}", dialog.GivenResponse);
        }
    }
}