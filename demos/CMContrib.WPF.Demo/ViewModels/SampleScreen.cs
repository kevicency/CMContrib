using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;

namespace Caliburn.Micro.Contrib.Demo
{
    public abstract class SampleScreen : Screen, ISample
    {
        string _code;

        string _codeFile;

        public SampleScreen()
        {
            CodeFile = string.Format("{0}.cs", GetType().Name);
            DisplayName = GetType().Name.Replace("ViewModel", "");
            DisplayName = new Regex(@"[A-Z]").Replace(DisplayName, x => " " + x.Captures[0].Value).Trim(); // Decamel
            Description = Properties.Demo.LoremIpsum;
            ExecuteMessage = "Execute";
            LoadCodeFromFile();
        }

        protected string CodeFile
        {
            get { return _codeFile; }
            set
            {
                _codeFile = value;
                Code = null;
            }
        }

        #region ISample Members

        public SampleCategory Category { get; protected set; }
        public string Description { get; protected set; }

        public string Code
        {
            get { return _code ?? (_code = LoadCodeFromFile()); }
            protected set { _code = value; }
        }

        public string ExecuteMessage { get; protected set; }

        public abstract IEnumerable<IResult> Execute();

        #endregion

        string LoadCodeFromFile()
        {
#if SILVERLIGHT

            var uri = new Uri(
                string.Format("Caliburn.Micro.Contrib.SL.Demo;component/Resources/Source/{0}", CodeFile),
                UriKind.Relative);
            var streamInfo = Application.GetResourceStream(uri);
            if (streamInfo != null)
            {
                Stream stream = streamInfo.Stream;
                var sr = new StreamReader(stream);
                return sr.ReadToEnd();
            }
#else
            var samplesPath = Path.Combine("ViewModels", "Samples");
            var file = Path.Combine(samplesPath, CodeFile);
            if (File.Exists(file))
            {
                    var lines = File.ReadAllLines(file)
                    .ToArray();
                return string.Join(Environment.NewLine, lines);
            }
#endif
            else
            {
                return string.Format("No Code File");
            }
        }
    }
}