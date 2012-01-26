using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Resources;

namespace Caliburn.Micro.Contrib.Demo
{
    public abstract class SampleScreen : Screen, ISample
    {
        public SampleScreen()
        {
            DisplayName = GetType().Name.Replace("ViewModel", "");
            DisplayName = new Regex(@"[A-Z]").Replace(DisplayName, x => " " + x.Captures[0].Value).Trim(); // Decamel
            Description = Properties.Demo.LoremIpsum;
            ExecuteMessage = "Execute";
            LoadCodeFromFile();
        }

        public SampleCategory Category { get; protected set; }
        public string Description { get; protected set; }
        public string Code { get; protected set; }

        public string ExecuteMessage { get; protected set; }

        public abstract IEnumerable<IResult> Execute();

        void LoadCodeFromFile()
        {
            var filename = string.Format("{0}.cs", GetType().Name);
#if SILVERLIGHT
           
            var uri = new Uri(
                string.Format("Caliburn.Micro.Contrib.SL.Demo;component/Resources/Source/{0}", filename),
                UriKind.Relative);
            var streamInfo = Application.GetResourceStream(uri); 
            if (streamInfo != null)
            {
                Stream stream = streamInfo.Stream;
                StreamReader sr = new StreamReader(stream);
                Code = sr.ReadToEnd();
            }
#else
            var samplesPath = Path.Combine("ViewModels", "Samples");
            var file = Path.Combine(samplesPath, filename);
            if (File.Exists(file))
            {
                    var lines = File.ReadAllLines(file)
                    .SkipWhile(line => !string.IsNullOrWhiteSpace(line)) // Skip usings in code
                    .Skip(1)
                    .ToArray();
                Code = string.Join(Environment.NewLine, lines);
            }
#endif
            else
            {
                Code = string.Format("// Code file '{0}' not found.", filename);
            }
        }
    }
}