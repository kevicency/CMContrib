using System.ComponentModel.Composition;
using System.Windows;
using Caliburn.Micro.Contrib.Dialogs;
using WPF.Themes;

namespace Caliburn.Micro.Contrib.Demo
{
    [Export]
    public partial class ShellView : Window, IBusyIndicator
    {
        public ShellView()
        {
            InitializeComponent();
        }

        public void Busy(string message)
        {
            Indicator.BusyContent = message;
            Indicator.IsBusy = true;
        }

        public void Idle()
        {
            Indicator.IsBusy = false;
        }
    }
}