using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Documents;

namespace Caliburn.Micro.Contrib.Demo.Converters
{
    public class MemeIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var name = value.ToString();
            name = name.ToLowerInvariant().Replace(" ", "_");

            return string.Format("../../Resources/Images/{0}.png", name);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
