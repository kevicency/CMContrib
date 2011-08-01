using System.Windows;
using System.Windows.Controls;

namespace Caliburn.Micro.Contrib
{
    /// <summary>
    ///   A static helper class which provides an Attached Property for closing windows via bindings
    /// </summary>
    public static class DialogCloser
    {
        /// <summary>
        /// Attach this property to a window and bind the value to a property of your ViewModel allos you to close the window in a MVVM Style
        /// </summary>
        public static readonly DependencyProperty DialogResultProperty =
            DependencyProperty.RegisterAttached(
                "DialogResult",
                typeof(bool?),
                typeof(DialogCloser),
                new PropertyMetadata(DialogResultChanged));

        /// <summary>
        /// Callback which sets the dialog result of the attaches window
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void DialogResultChanged(
            DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            var window = d as ChildWindow;
            if (window != null) window.DialogResult = e.NewValue as bool?;
        }

        /// <summary>
        /// Sets the dialog result of the UIElement
        /// </summary>
        /// <param name="target"></param>
        /// <param name="value"></param>
        public static void SetDialogResult(UIElement target, bool? value)
        {
            target.SetValue(DialogResultProperty, value);
        }

        /// <summary>
        /// Gets the dialog result of the UIElement
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool? GetDialogResult(UIElement obj)
        {
            return (bool?)obj.GetValue(DialogResultProperty);
        }
    }
}