using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using Caliburn.Micro.Contrib.Demo.Results;
using Caliburn.Micro.Contrib.Results;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof(ISample))]
    public class BrowseFolderViewModel : SampleScreen
    {
        public BrowseFolderViewModel()
        {
            Category = SampleCategory.FileDialogs;
            Description =
                "BrowseFolderResult wraps a FolderBrowserDialog in a Result and offers a fluent syntax to configure the dialog. " +
                "The selected path is stored in the SelectedPath property of the result. You can alternatively provide a callback action " +
                "that is invoked on the selected path.";
        }

        public override IEnumerable<IResult> Execute()
        {
            IList<string> folderItems = new List<string>();

            var browseResult = new BrowseFolderResult("Select a folder")
                .AllowNewFolder()
                .In(Environment.SpecialFolder.MyDocuments)
                .WithSelectedPathDo(x =>
                {
                    foreach (var file in Directory.GetFiles(x))
                    {
                        folderItems.Add(file);
                    }
                });

            yield return browseResult
                .WhenCancelled().Execute(new LogResult("BrowseFolder cancelled").AsEnumerable);

            yield return new LogResult(string.Format("Files in {0}:\n{1}",
                                                     browseResult.SelectedPath,
                                                     String.Join(Environment.NewLine, folderItems.ToArray())));
        }
    }
}