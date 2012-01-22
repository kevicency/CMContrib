namespace Caliburn.Micro.Contrib.Dialogs
{
    /// <summary>
    ///   Model for a Information Dialog
    /// </summary>
    public class Information : Dialog
    {
        public Information(string message)
            : base(DialogType.Information, message, Answer.Ok)
        {            
        }
        public Information(string message, params Answer[] possibleResponens)
            : base(DialogType.Information, message, possibleResponens)
        {
        }

        public Information(string subject, string message, params Answer[] possibleResponens)
            : base(DialogType.Information, subject, message, possibleResponens)
        {
        }
    }
}