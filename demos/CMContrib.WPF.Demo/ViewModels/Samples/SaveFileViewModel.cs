using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using Caliburn.Micro.Contrib.Demo.Results;
using Caliburn.Micro.Contrib.Results;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof(ISample))]
    public class SaveFileViewModel : SampleScreen
    {
        public SaveFileViewModel()
        {
            Category = SampleCategory.FileDialogs;
            Description =
           "SaveFileResult wraps a SaveFileDialog in a Result and offers a fluent syntax to configure the dialog. " +
           "The selected file is stored in the FileName property of the result. " +
           "You can alternatively provide a callback action that is invoked on the selected file.";
      
        }

        public override IEnumerable<IResult> Execute()
        {
            yield return new SaveFileResult()
                .PromptForOverwrite()
                .FilterFiles(x => x.AddFilter("xml").WithDefaultDescription()
                                      .AddFilter("txt").WithDescription("Text files")
                                      .AddFilter("doc", "docx").WithDescription("Word Documents")
                                      .AddAllFilesFilter(isDefault: true))
                .In(@"C:\")
                .WithFileDo(file => { File.WriteAllText(file, "test"); })
                .WhenCancelled().Execute(new LogResult("SaveFile cancelled").AsCoroutine);

            yield return new LogResult("Saving successfull");
        }
    }
}