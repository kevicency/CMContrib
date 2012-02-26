using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using Caliburn.Micro.Contrib.Dialogs;

namespace Caliburn.Micro.Contrib.Demo.Converters
{
    public class DialogColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var dialogtype = (DialogType) value;
            switch (dialogtype)
            {
                case DialogType.None:
                    return Colors.Black;
                    break;
                case DialogType.Question:
                    return Colors.Blue;
                    break;
                case DialogType.Warning:
                    return Colors.Yellow;
                    break;
                case DialogType.Information:
                    return Colors.Green;
                    break;
                case DialogType.Error:
                    return Colors.Red;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}