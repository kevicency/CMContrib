using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Caliburn.Micro.Contrib.Dialogs
{
    /// <summary>
    ///   Interaction logic for DialogView.xaml
    /// </summary>
    public partial class DialogView : Window
    {
        public DialogView()
        {
            InitializeComponent();
            Activated += (sender, args) =>
            {
                DependencyObject child = Responses;
                while (child != null)
                {
                    child = VisualTreeHelper.GetChild(child, 0);
                    if (child is Button)
                    {
                        (child as Button).Focus();
                        break;
                    }
                }
            };
        }
    }
}