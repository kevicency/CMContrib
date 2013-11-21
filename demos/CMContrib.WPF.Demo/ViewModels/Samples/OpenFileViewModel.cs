using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using Caliburn.Micro.Contrib.Demo.Results;
using Caliburn.Micro.Contrib.Results;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof(ISample))]
    public class OpenFileViewModel : SampleScreen
    {
        public OpenFileViewModel()
        {
            Category = SampleCategory.FileDialogs;
            Description =
                "OpenFileResult wraps a OpenFileDialog in a Result and offers a fluent syntax to configure the dialog. " +
                "The selected files are stored in the FileNames property (or in the FileName property if only one file is selected) of the result. " +
                "You can alternatively provide a callback action that is invoked on the selected file(s).";
        }

        public override IEnumerable<IResult> Execute()
        {
            IList<string> fileContents = new List<string>();

            yield return new OpenFileResult()
                .FilterFiles(x => x.AddFilter("xml").WithDefaultDescription()
                                      .AddFilter("txt").WithDescription("Text files")
                                      .AddFilter("doc", "docx").WithDescription("Word Documents")
                                      .AddAllFilesFilter(isDefault: true))
                .In(@"C:\")
                .AllowMultipleFiles()
                .WithFilesDo(files =>
                {
                    foreach (var file in files)
                    {
                        var content = file + Environment.NewLine;
                        content += File.ReadAllText(file);
                        fileContents.Add(content);
                    }
                })
                .WhenCancelled().Execute(new LogResult("OpenFile cancelled").AsEnumerable);


            foreach (var fileContent in fileContents)
            {
                yield return new LogResult(fileContent);
            }
        }
    }
}