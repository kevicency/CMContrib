using System.Windows;
using Caliburn.Micro.Contrib.Interaction;
using WPF.Themes;

namespace Caliburn.Micro.Contrib.Demo
{
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