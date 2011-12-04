using System;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Data;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using Caliburn.Micro.Contrib.Dialogs;

namespace Caliburn.Micro.Contrib.Converter
{
    [ValueConversion(typeof (string), typeof (BitmapSource))]
    public class DialogTypeToSystemIconConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type type, object parameter, CultureInfo culture)
        {
            if (!(value is DialogType)) return null;

            var messageType = (DialogType) value;

            Icon icon;

            if (messageType == DialogType.Custom) icon = SystemIcons.Application;
            else
            {
                icon = (Icon) typeof (SystemIcons)
                                  .GetProperty(messageType.ToString(), BindingFlags.Public | BindingFlags.Static)
                                  .GetValue(null, null);
            }
            BitmapSource bs = Imaging.CreateBitmapSourceFromHIcon(icon.Handle,
                                                                  Int32Rect.Empty,
                                                                  BitmapSizeOptions.FromEmptyOptions());

            return bs;
        }

        public object ConvertBack(object value, Type type, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        #endregion
    }
}