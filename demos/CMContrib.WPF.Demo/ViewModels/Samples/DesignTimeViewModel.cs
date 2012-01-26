using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof(ISample))]
    public class DesignTimeViewModel : SampleScreen
    {
        public DesignTimeViewModel()
        {
            Category = SampleCategory.Core;
            Description =
                "CMContrib provides an AttachedProperty that allows you to enable Caliburn's auto bindings during design time.\n" +
                "It is as simple as adding the AttachedProperty 'DesignTimeSupport:DesignTime.Enable=\"True\"' to the controls that uses auto binding.\n" +
                "Examples can be found in the ShellView.xaml";

        }

        public bool CanExecute { get { return false; } }

        public override IEnumerable<IResult> Execute()
        {
            yield break;
        }
    }
}