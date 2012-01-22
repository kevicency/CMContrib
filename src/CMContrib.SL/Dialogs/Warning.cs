namespace Caliburn.Micro.Contrib.Dialogs
{
    /// <summary>
    ///   Model for a Warning Dialog
    /// </summary>
    public class Warning : Dialog
    {
        public Warning(string message)
            : base(DialogType.Warning, message, Answer.Ok)
        {
        }

        public Warning(string message, params Answer[] possibleResponens)
            : base(DialogType.Warning, message, possibleResponens)
        {
        }

        public Warning(string subject, string message, params Answer[] possibleResponens)
            : base(DialogType.Warning, subject, message, possibleResponens)
        {
        }
    }
}