using System;
using Caliburn.Micro.Contrib.Dialogs;

namespace Caliburn.Micro.Contrib.Results
{
    public class DialogResult<TResponse> : IResult
    {
        private TResponse _cancelResponse;
        private bool _hasCancelResponse;

        private Func<IDialogViewModel<TResponse>> _locateVM = () => new DialogViewModel<TResponse>();

        public DialogResult(Dialog<TResponse> dialog)
        {
            Dialog = dialog;
        }

        //public IWindowManager WindowManager { get; set; }

        public Dialog<TResponse> Dialog { get; private set; }

        #region IResult Members

        public void Execute(ActionExecutionContext context)
        {
            IDialogViewModel<TResponse> vm = _locateVM();
            vm.Dialog = Dialog;

            // we need the event because show dialog doesn't block in the SL context
            Dialog.ResponseGiven += OnResponseGiven;

            Micro.Execute.OnUIThread(() => IoC.Get<IWindowManager>().ShowDialog(vm));
        }

        public event EventHandler<ResultCompletionEventArgs> Completed;

        #endregion

        private void OnResponseGiven(object sender, EventArgs eventArgs)
        {
            var dialog = sender as Dialog<TResponse>;

            dialog.ResponseGiven -= OnResponseGiven;

            var resultArgs = new ResultCompletionEventArgs
                             {
                                 WasCancelled =
                                     _hasCancelResponse && Equals(Dialog.GivenResponse, _cancelResponse)
                             };

            Completed(this, resultArgs);
        }

        public DialogResult<TResponse> CancelOnResponse(TResponse response)
        {
            _cancelResponse = response;
            _hasCancelResponse = true;

            return this;
        }

        public DialogResult<TResponse> In(IDialogViewModel<TResponse> dialogViewModel)
        {
            _locateVM = () => dialogViewModel;

            return this;
        }

        public DialogResult<TResponse> In<TDialogViewModel>()
            where TDialogViewModel : IDialogViewModel<TResponse>
        {
            _locateVM = () => IoC.Get<TDialogViewModel>();

            return this;
        }
    }
}