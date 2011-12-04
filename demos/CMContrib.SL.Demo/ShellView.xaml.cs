using System.Windows;
using System.Windows.Controls;

namespace Caliburn.Micro.Contrib.Demo
{
    public partial class ShellView : UserControl, IBusyIndicator
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