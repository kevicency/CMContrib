using System.Collections.Generic;
using System.ComponentModel.Composition;
using Caliburn.Micro.Contrib.Demo.Results;
using Caliburn.Micro.Contrib.Dialogs;

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