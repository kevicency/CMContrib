using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof(ISample))]
    public class ConfigurationViewModel : SampleScreen
    {
        public ConfigurationViewModel()
        {
            Category = SampleCategory.Core;
            Description =
                "Because some of CMContribs features can be used, they have to be enabled in the bootstrapper.\n" +
                "\t* The first line enables the extra syntax for ActionMessages.\n" +
                "\t* The second line enables the usage of Attributes (RescueAttribute, ...).\n" +
                "\t* The third line allows you to plug in your own ResourceManager to localize enums.";
            Code = File.ReadAllText(@"Resources\config_sample.txt");
        }

        public bool CanExecute { get { return false; } }

        public override IEnumerable<IResult> Execute()
        {
            yield break;
        }
    }
}