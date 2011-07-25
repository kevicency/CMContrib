using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Threading;
using Caliburn.Micro.Contrib.Interaction;
using Caliburn.Micro.Contrib.Results;
using Caliburn.Micro.Contrib.WPF.Demo.Results;
using Ookii.Dialogs.Wpf;

namespace Caliburn.Micro.Contrib.WPF.Demo.ViewModels
{
    [Export(typeof(IDemo))]
    public class DialogsDemoViewModel : Screen, IDemo
    {
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
                                         fileContents.Add(File.ReadAllText(file));
                                     }
                                 })
                                 .WhenCancelled().Execute(OnCancel);

            foreach (var fileContent in fileContents)
            {
                yield return new LogResult(fileContent);
            }
        }

        public IEnumerable<IResult> SaveFile()
        {
            yield return new SaveFileResult()
                .PromptForCreate()
                .PromptForOverwrite()
                .FilterFiles(x => x.AddFilter("xml").WithDefaultDescription()
                                      .AddFilter("txt").WithDescription("Text files")
                                      .AddFilter("doc", "docx").WithDescription("Word Documents")
                                      .AddAllFilesFilter(isDefault: true))
                .In(@"C:\")
                .WithFileDo(file => { File.WriteAllText(file, "test"); })
                .WhenCancelled().Execute(OnCancel);

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
                .WhenCancelled().Execute(OnCancel);

            yield return new LogResult(string.Format("Files in {0}:", browseResult.SelectedPath));

            foreach (var folderItem in folderItems)
            {
                yield return new LogResult(folderItem);
            }
        }

        public IEnumerable<IResult> Calculate(int parameter)
        {
            var message = string.Empty;

            yield return new ProgressResult<int, int>("Calculating...")
                .SetText(string.Format("Slowly calculating {0}!", parameter))
                .UseParameter(parameter)
                .ShowTimeRemaining()
                .AllowCancel("Aborting the calculation.")
                .Start((sender, args) =>
                           {
                               var dialog = sender as ProgressDialog;
                               var arg = (int)args.Argument;

                               if (arg < 1)
                                   throw new ArgumentException("Argument must be >= 1");

                               int result = 1;
                               dialog.ReportProgress(0, null, "Calculation done: 0%");

                               Faculty(arg, i =>
                                                {
                                                    if (dialog.CancellationPending)
                                                    {
                                                        args.Cancel = true;
                                                        return true;
                                                    }

                                                    dialog.ReportProgress(i * 100 / arg, null,
                                                                          string.Format("Calculation done: {0}%", i * 100 / arg));

                                                    return false;
                                                });

                               args.Result = result;
                           })
                .WithResultDo((param, res) => message = string.Format("{0}! = {1}", param, res))
                .WhenCancelled().Execute(OnCancel);

            yield return new LogResult(message);
        }

        private static int Faculty(int n, Func<int, bool> callback)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                Thread.Sleep(5000 / n);

                result *= i;

                if (callback(i))
                    return -1;
            }

            return result;
        }

        public IEnumerable<IResult> ShowQuestion()
        {
            var question = new Question("A Question",
                                        "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet?",
                                        Answer.Yes, Answer.No);

            yield return question.AsResult()
                .CancelOnResponse(Answer.Cancel)
                .WhenCancelled().Execute(OnCancel);

            yield return new LogResult(string.Format("You responded with {0}", question.GivenResponse));
        }

        public IEnumerable<IResult> ShowInformation()
        {
            var information = new Information("An Information",
                                              "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet?");

            yield return information.AsResult();
        }

        public IEnumerable<IResult> ShowWarning()
        {
            var warning = new Warning("A Question",
                                      "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet?",
                                      Answer.Retry, Answer.Ignore, Answer.Abort);

            yield return warning.AsResult()
                .CancelOnResponse(Answer.Abort)
               .WhenCancelled().Execute(OnCancel);

            yield return new LogResult(string.Format("You responded with {0}", warning.GivenResponse));
        }

        public IEnumerable<IResult> ShowError()
        {
            var error = new Error("A Question",
                                  "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet?");

            yield return error.AsResult()
                .CancelOnResponse(Answer.Cancel)
               .WhenCancelled().Execute(OnCancel);

            yield return new LogResult(string.Format("You responded with {0}", error.GivenResponse));
        }

        private static IEnumerable<IResult> OnCancel()
        {
            yield return new LogResult(string.Format("Coroutine was cancelled"));
        }
    }
}