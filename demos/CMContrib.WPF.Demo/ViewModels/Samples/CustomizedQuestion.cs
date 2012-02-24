using System.Collections.Generic;
using System.ComponentModel.Composition;
using Caliburn.Micro.Contrib.Dialogs;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof(ISample))]
    public class CustomizedQuestion : DialogSampleScreen
    {
        public CustomizedQuestion()
        {
            Description = "A customized question with a complex type as response.";
        }

        public override IEnumerable<IResult> Execute()
        {
            var custom = new Dialog<MemeAnswer>(DialogType.Question,
                "Your favorite Meme?",
                new MemeAnswer("Trollface", "Dont feed the troll !"),
                new MemeAnswer("Damned", "Y U NO CODE GUD !!"),
                new MemeAnswer("Forever Alone", "Story of my life..."),
                new MemeAnswer("Apopleptic", "Not another VB.NET project !!!!111"));

            yield return custom.AsResult()
                .PrefixViewContextWith("Meme");
        }
    }
}