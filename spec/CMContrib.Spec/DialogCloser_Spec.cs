using System.Windows;
using Caliburn.Micro.Contrib;
using Machine.Fakes;
using Machine.Fakes.Adapters.Moq;
using Machine.Specifications;

namespace CMContrib.Spec
{
    [Subject(typeof (DialogCloser))]
    public class DialogCloser_Spec : WithFakes<MoqFakeEngine>
    {
        Establish that = () => { Window = new Window(); };

        protected static Window Window;

        [Subject(typeof (DialogCloser))]
        public class when_set_on_an_active_dialog_window : DialogCloser_Spec
        {
            Because of = () =>
            {
                Window.Activated += (sender, args) => Window.SetValue(DialogCloser.DialogResultProperty, true);
                Window.ShowDialog();
            };

            It sets_the_dialog_result_of_the_window = () => Window.DialogResult.ShouldEqual(true);
        }

        [Subject(typeof (DialogCloser))]
        public class when_set_on_an_inactive_dialog_window : DialogCloser_Spec
        {
            Because of = () => Window.SetValue(DialogCloser.DialogResultProperty, true);

            It doesnt_set_the_dialog_result = () => Window.DialogResult.ShouldEqual(null);
        }
    }
}