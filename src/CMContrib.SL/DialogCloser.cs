using System.Windows;
using System.Windows.Controls;

namespace Caliburn.Micro.Contrib
{
    /// <summary>
    ///   A static helper class which provides an Attached Property for closing windows via bindings
    /// </summary>
    public static class DialogCloser
    {
        public static readonly DependencyProperty DialogResultProperty =
            DependencyProperty.RegisterAttached(
                "DialogResult",
                typeof (bool?),
                typeof (DialogCloser),
                new PropertyMetadata(DialogResultChanged));

        private static void DialogResultChanged(
            DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            var window = d as ChildWindow;
            if (window != null) window.DialogResult = e.NewValue as bool?;
        }

        public static void SetDialogResult(UIElement target, bool? value)
        {
            target.SetValue(DialogResultProperty, value);
        }

        public static bool? GetDialogResult(UIElement obj)
        {
            return (bool?) obj.GetValue(DialogResultProperty);
        }
    }
}