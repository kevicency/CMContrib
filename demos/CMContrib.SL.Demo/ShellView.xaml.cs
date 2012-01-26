using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;

namespace Caliburn.Micro.Contrib.Demo
{
    [Export]
    public partial class ShellView : UserControl, IBusyIndicator
    {
        public ShellView()
        {
            InitializeComponent();
        }

        public void Busy(string message)
        {
            BusyIndicator.BusyContent = message;
            BusyIndicator.IsBusy = true;
        }

        public void Idle()
        {
            BusyIndicator.IsBusy = false;
        }
    }
}