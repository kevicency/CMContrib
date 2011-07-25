using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Caliburn.Micro.Contrib.WPF.Demo.Views
{
    /// <summary>
    /// Interaction logic for DialogsDemoView.xaml
    /// </summary>
    public partial class DialogsDemoView : UserControl
    {
        public DialogsDemoView()
        {
            InitializeComponent();

            Loaded += (sender, args) =>
            {
                SpecialFolders.ItemsSource = Enum.GetValues(typeof(Environment.SpecialFolder));
                SpecialFolders.SelectedIndex = 0;
            };
        }
    }
}
