namespace Caliburn.Micro.Contrib.Dialogs
{
    /// <summary>
    ///   Model for a Question Dialog
    /// </summary>
    public class Question : Dialog
    {
        public Question(string message)
            :base(DialogType.Question, message, Answer.Yes, Answer.No)
        {
        }

        public Question(string message, params Answer[] possibleResponens)
            : base(DialogType.Question, message, possibleResponens)
        {
        }

        public Question(string subject, string message, params Answer[] possibleResponens)
            : base(DialogType.Question, subject, message, possibleResponens)
        {
        }
    }
}