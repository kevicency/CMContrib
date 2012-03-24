using System;
using System.Collections.Generic;
using System.Linq;

namespace Caliburn.Micro.Contrib.Dialogs
{
    public class Dialog<TResponse>
    {
        private TResponse _givenResponse;

        public Dialog(string subject, string message, params TResponse[] possibleResponens)
            : this(DialogType.None, subject, message, possibleResponens)
        {
        }

        public Dialog(DialogType dialogType, string message, params TResponse[] possibleResponens)
            : this(dialogType, Localizer.LocalizeEnum(dialogType), message, possibleResponens)
        {
        }

        public Dialog(DialogType dialogType, string subject, string message, params TResponse[] possibleResponens)
        {
            if (!possibleResponens.Any())
                throw new ArgumentException("No possible responses are given", "possibleResponens");

            DialogType = dialogType;
            Subject = subject;
            Message = message;
            PossibleResponses = possibleResponens;
        }

        public string Subject { get; set; }
        public string Message { get; set; }

        public DialogType DialogType { get; set; }
        public IEnumerable<TResponse> PossibleResponses { get; protected set; }

        public TResponse GivenResponse
        {
            get { return _givenResponse; }
            set
            {
                _givenResponse = value;
                IsResponseGiven = true;
                if (ResponseGiven != null) ResponseGiven(this, EventArgs.Empty);
            }
        }

        public bool IsResponseGiven { get; private set; }
        public event EventHandler ResponseGiven;
    }

    public class Dialog : Dialog<Answer>
    {
        public Dialog(string subject, string message, params Answer[] possibleResponens)
            : base(subject, message, possibleResponens)
        {
        }

        public Dialog(DialogType dialogType, string message, params Answer[] possibleResponens)
            : base(dialogType, message, possibleResponens)
        {
        }

        public Dialog(DialogType dialogType, string subject, string message, params Answer[] possibleResponens)
            : base(dialogType, subject, message, possibleResponens)
        {
        }
    }
}