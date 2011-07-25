using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Caliburn.Micro.Contrib
{
    public static class ButtonEx
    {
        public static DependencyProperty IsDefaultProperty =
              DependencyProperty.RegisterAttached("IsDefault",
                                                  typeof(bool),
                                                  typeof(ButtonEx),
                                                  new PropertyMetadata(false, IsDefaultChanged));

        private static void IsDefaultChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = d as Button;
            var isDefault = (bool)e.NewValue;

            if (button != null)
            {
                var rootElement = GetRootElement(button);

                if (isDefault)
                {

                    rootElement.KeyUp += ButtonOnKeyUp;
                }
                else
                {
                    rootElement.KeyUp -= ButtonOnKeyUp;
                }
            }
        }

        private static FrameworkElement GetRootElement(DependencyObject o)
        {
            var parent = VisualTreeHelper.GetParent(o);
            var tmp = parent;
            while ((tmp = VisualTreeHelper.GetParent(parent) as FrameworkElement) != null)
            {
                parent = tmp;
            }

            return parent as FrameworkElement;
        }

        private static void ButtonOnKeyUp(object sender, KeyEventArgs args)
        {
            var peer = new ButtonAutomationPeer(sender as Button);

            if (args.Key == Key.Enter)
            {
                peer.SetFocus();
                (sender as Button).Dispatcher
                    .BeginInvoke(() =>
                                 {
                                     var invokeProv = peer.GetPattern(PatternInterface.Invoke) as IInvokeProvider;
                                     if (invokeProv != null) invokeProv.Invoke();
                                 });
            }
        }

        public static bool GetIsDefault(UIElement obj)
        {
            return (bool)obj.GetValue(IsDefaultProperty);
        }

        public static void SetIsDefault(UIElement obj, bool isDefault)
        {
            obj.SetValue(IsDefaultProperty, isDefault);
        }

    }
}
