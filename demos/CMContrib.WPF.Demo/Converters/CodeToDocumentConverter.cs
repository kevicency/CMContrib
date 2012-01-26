using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Documents;
using ColorCode;

namespace Caliburn.Micro.Contrib.Demo.Converters
{
    public class SyntaxHighlighter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var text = System.Convert.ToString(value);
            var html = new CodeColorizer().Colorize(text, Languages.CSharp);

            //    FlowDocument flowDocument = new FlowDocument();
            //    string xaml = HtmlToXamlConverter.ConvertHtmlToXaml(value.ToString(), false);

            //    using (MemoryStream stream = new MemoryStream((new ASCIIEncoding()).GetBytes(xaml)))
            //    {
            //        TextRange text = new TextRange(flowDocument.ContentStart, flowDocument.ContentEnd);
            //        text.Load(stream, DataFormats.Xaml);
            //    }

            //    return flowDocument;
            //}
            //return value;
            return html;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
