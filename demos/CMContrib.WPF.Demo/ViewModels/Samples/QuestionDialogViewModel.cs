using System.Collections.Generic;
using System.ComponentModel.Composition;
using Caliburn.Micro.Contrib.Demo.Results;
using Caliburn.Micro.Contrib.Dialogs;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof(ISample))]
    public class QuestionDialogViewModel : DialogSampleScreen
    {
        public QuestionDialogViewModel()
        {
            Description = "Special Dialog to ask the user q question.";
        }

        public override IEnumerable<IResult> Execute()
        {
            var question = new Question(Properties.Demo.LoremIpsum,
                                        Answer.Yes,
                                        Answer.No);

            yield return question.AsResult()
                // .CancelOnResponse(Answer.No) When two or more responses are given, the last response is per default the cancel response
                .WhenCancelled().Execute(new LogResult("Question result cancelled").AsCoroutine)
                .WhenCancelled().Override();

            yield return LogResponse(question);
        }
    }
}