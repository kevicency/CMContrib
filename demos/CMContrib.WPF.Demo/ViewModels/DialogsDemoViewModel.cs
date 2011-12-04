using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Threading;
using Caliburn.Micro.Contrib.Demo.Results;
using Caliburn.Micro.Contrib.Dialogs;
using Caliburn.Micro.Contrib.Results;
using Ookii.Dialogs.Wpf;

namespace Caliburn.Micro.Contrib.Demo.ViewModels
{
    [Export(typeof(IDemo))]
    public class DialogsDemoViewModel : Screen, IDemo
    {
        const string DialogText = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet?";         

        public DialogsDemoViewModel()
        {
            DisplayName = "Dialogs Demo";
        }

        public IEnumerable<IResult> OpenFile()
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
                                 .WhenCancelled().Execute(new LogResult("OpenFile cancelled").AsCoroutine);


            foreach (var fileContent in fileContents)
            {
                yield return new LogResult(fileContent);
            }
        }

        public IEnumerable<IResult> SaveFile()
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

        public IEnumerable<IResult> Browse(Environment.SpecialFolder folder)
        {
            IList<string> folderItems = new List<string>();

            var browseResult = new BrowseFolderResult("Select a folder")
                .AllowNewFolder()
                .In(folder)
                .WithSelectedPathDo(x =>
                                        {
                                            foreach (var file in Directory.GetFiles(x))
                                            {
                                                folderItems.Add(file);
                                            }
                                        });

            yield return browseResult
                .WhenCancelled().Execute(new LogResult("BrowseFolder cancelled").AsCoroutine);

            yield return new LogResult(string.Format("Files in {0}:\n{1}",
                                                     browseResult.SelectedPath,
                                                     String.Join(Environment.NewLine, folderItems.ToArray())));
        }

        public IEnumerable<IResult> ShowQuestion()
        {
            var question = new Question(DialogText,
                                        Answer.Yes, Answer.No);

            yield return question.AsResult()
                .CancelOnResponse(Answer.No)
                .WhenCancelled().Execute(new LogResult("ShowQuestion cancelled").AsCoroutine);

            yield return new LogResult(string.Format("You responded with {0}", question.GivenResponse));
        }

        public IEnumerable<IResult> ShowInformation()
        {
            var information = new Information(DialogText,
                                              Answer.Ok);

            yield return information.AsResult();
        }

        public IEnumerable<IResult> ShowWarning()
        {
            var warning = new Warning(DialogText,
                                      Answer.Retry, Answer.Ignore, Answer.Abort);

            yield return warning.AsResult()
                .CancelOnResponse(Answer.Abort)
               .WhenCancelled().Execute(new LogResult("Aborted").AsCoroutine);

            yield return new LogResult(string.Format("You responded with {0}", warning.GivenResponse));
        }

        public IEnumerable<IResult> ShowError()
        {
            var error = new Error(DialogText,
                                  Answer.Ok);

            yield return error.AsResult();

            yield return new LogResult(string.Format("You responded with {0}", error.GivenResponse));
        }
    }
}