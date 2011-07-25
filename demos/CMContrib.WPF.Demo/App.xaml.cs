using System.Windows;
using Microsoft.Win32;

namespace Caliburn.Micro.Contrib.WPF.Demo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var saveFileDialog = new SaveFileDialog();
        }
    }
}
