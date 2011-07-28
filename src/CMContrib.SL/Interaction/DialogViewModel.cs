using System;
using System.Collections.Generic;
using System.Linq;

namespace Caliburn.Micro.Contrib.Interaction
{
    public class DialogViewModel : DialogViewModel<Answer>
    {
    }

    public class DialogViewModel<TResponse> : Screen, IDialogViewModel<TResponse>
    {
        private Dialog<TResponse> _dialog;

        public DialogViewModel()
            : this(null)
        {
        }

        public DialogViewModel(Dialog<TResponse> dialog)
        {
            Responses = new BindableCollection<BindableResponse<TResponse>>();
            Dialog = dialog;
        }

        #region IDialogViewModel<TResponse> Members

        public Dialog<TResponse> Dialog
        {
            get { return _dialog; }
            set
            {
                _dialog = value;

                CreateResponses();
            }
        }

        public bool? IsClosed { get; set; }

        public IObservableCollection<BindableResponse<TResponse>> Responses { get; private set; }

        public void Respond(BindableResponse<TResponse> bindableResponse)
        {
            if (bindableResponse == null) throw new ArgumentNullException("bindableResponse");

            Dialog.GivenResponse = bindableResponse.Response;
            IsClosed = true;
        }

        #endregion

        private void CreateResponses()
        {
            Responses.Clear();

            if (Dialog != null)
            {
                var count = Dialog.PossibleResponses.Count();

                if (count > 0)
                {
                    Responses.AddRange(Dialog.PossibleResponses
                                           .Select(x => new BindableResponse<TResponse> {Response = x}));

                    Responses.First().IsDefault = true;
                    if (count > 1) Responses.Last().IsCancel = true;
                }
            }
        }

        protected override void OnDeactivate(bool close)
        {
            base.OnDeactivate(close);
            if (close) EnsureResponseOnClose();
        }

        private void EnsureResponseOnClose()
        {
            if (Dialog.IsResponseGiven) return;

            BindableResponse<TResponse> response;

            if (Responses.Any(x => x.IsCancel)) response = Responses.First(x => x.IsCancel);
            else if (Responses.Any(x => x.IsDefault)) response = Responses.First(x => x.IsDefault);
            else response = Responses.FirstOrDefault();

            Respond(response);
        }
    }
}