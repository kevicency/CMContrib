namespace Caliburn.Micro.Contrib.Dialogs
{
    /// <summary>
    ///   Model for an Error Dialog
    /// </summary>
    public class Error : Dialog
    {
        public Error(string message)
            :base(DialogType.Error, message, Answer.Ok)
        {
        }

        public Error(string message, params Answer[] possibleResponens)
            : base(DialogType.Error, message, possibleResponens)
        {
        }

        public Error(string subject, string message, params Answer[] possibleResponens)
            : base(DialogType.Error, subject, message, possibleResponens)
        {
        }
    }
}