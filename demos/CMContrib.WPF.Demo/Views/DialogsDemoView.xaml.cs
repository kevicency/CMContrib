using System;
using System.Windows.Controls;

namespace Caliburn.Micro.Contrib.Demo.Views
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
