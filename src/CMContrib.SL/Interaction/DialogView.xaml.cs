using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Caliburn.Micro.Contrib.Interaction
{
    public partial class DialogView : ChildWindow
    {
        public DialogView()
        {
            InitializeComponent();
        }

        private void ChildWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Escape)
            {
                foreach (var button in GetButtons())
                {
                    var bindableResponse = button.DataContext as IBindableResponse;

                    if (e.Key == Key.Escape && bindableResponse.IsCancel
                        || e.Key == Key.Enter && bindableResponse.IsDefault)
                    {
                        e.Handled = true;
                        var peer = new ButtonAutomationPeer(button);
                        var invokeProv = peer.GetPattern(PatternInterface.Invoke) as IInvokeProvider;
                        invokeProv.Invoke();

                        break;
                    }
                }
            }
        }

        private IEnumerable<Button> GetButtons()
        {
            var queue = new Queue<FrameworkElement>();
            queue.Enqueue(Responses);

            while (queue.Count > 0)
            {
                FrameworkElement current = queue.Dequeue();
                if (current == null) continue;

                var button = current as Button;
                if (button != null)
                {
                    yield return button;
                }

                int count = VisualTreeHelper.GetChildrenCount(current);
                for (int i = 0; i < count; i++)
                {
                    queue.Enqueue(VisualTreeHelper.GetChild(current, i) as FrameworkElement);
                }
            }
        }
    }
}