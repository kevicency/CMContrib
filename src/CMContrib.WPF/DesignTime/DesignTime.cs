using System.Windows;
using System.Windows.Data;

namespace Caliburn.Micro.DesignTimeSupport
{
    public static class DesignTime
    {
        public static DependencyProperty EnableProperty =
            DependencyProperty.RegisterAttached(
                "Enable",
                typeof(bool),
                typeof(DesignTime),
                new PropertyMetadata(new PropertyChangedCallback(EnableChanged)));

#if !SILVERLIGHT && !WP7
        [AttachedPropertyBrowsableForTypeAttribute(typeof(DependencyObject))]
#endif
        public static bool GetEnable(DependencyObject dependencyObject)
        {
            return (bool)dependencyObject.GetValue(EnableProperty);
        }


        public static void SetEnable(DependencyObject dependencyObject, bool value)
        {
            dependencyObject.SetValue(EnableProperty, value);
        }

        static void EnableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!Execute.InDesignMode)
                return;

            BindingOperations.SetBinding(d, DataContextProperty, (bool)e.NewValue ? new Binding() : null);
        }


        private static readonly DependencyProperty DataContextProperty =
            DependencyProperty.RegisterAttached(
                "DataContext",
                typeof(object),
                typeof(DesignTime),
                new PropertyMetadata(new PropertyChangedCallback(DataContextChanged))
                );



        private static void DataContextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!Execute.InDesignMode)
                return;

            object enable = d.GetValue(EnableProperty);
            if (enable == null || ((bool)enable) == false || e.NewValue == null)
                return;

            var fe = d as FrameworkElement;
            if (fe == null)
                return;
       
            ViewModelBinder.Bind(e.NewValue, d, string.IsNullOrEmpty(fe.Name) ? fe.GetHashCode().ToString() : fe.Name);
        }
    }
}
