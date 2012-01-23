using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace Caliburn.Micro.Contrib.Converter
{
    /// <summary>
    /// Convention based localization of Enums
    /// </summary>
    public class EnumLocalizer : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Enum)
            {
                var @enum = (Enum) value;
                if (IsFlag(@enum))
                {
                    return Localizer.LocalizeFlag(@enum);
                }
                else
                {
                    return Localizer.LocalizeEnum(@enum);
                }
            }
            else
            {
                return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion

        private bool IsFlag(Enum @enum)
        {
            return @enum.GetType().GetCustomAttributes(typeof (FlagsAttribute), false).Any();
        }
    }
}