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

        Because of = () =>
        {
            Window.Activated += (sender, args) => Window.SetValue(DialogCloser.DialogResultProperty, true);
            Window.ShowDialog();
        };

        It sets_the_dialog_result_of_the_window = () => Window.DialogResult.ShouldEqual(true);

        protected static Window Window;
    }
}