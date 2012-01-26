using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows.Input;
using System.Windows.Media;
using Caliburn.Micro.Contrib.Demo.Results;
using Caliburn.Micro.Contrib.Dialogs;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof(ISample))]
    public class ComplexBindingViewModel : SampleScreen
    {
        public ComplexBindingViewModel()
        {
            Category = SampleCategory.Dynamic;
            Description =
                "CMContrib offers additional syntax for ActionMessages to support complex binding scenarios. " +
                "The additional syntax supports Xaml bindings in the Message as well as properties of special values. " +
                "The additional syntax must be enabled manually and is shown in the Configure() method of the AppBootstrapper";

            ExecuteMessage = "[Event Click] = [Action Execute($dataContext," +
                             "$dataContext.DisplayName," +
                             "$eventArgs," +
                             "{Binding Path=Foreground, ElementName=DisplayName}," +
                             "DisplayName.Text," +
                             "'true')]";
        }

        public override IEnumerable<IResult> Execute()
        {
            return Execute(null, null, null, null, null, false);
        }

        public IEnumerable<IResult> Execute(
            object dataContext,
            string title,
            object eventArgs,
            Brush binding,
            string content,
            bool b)
        {
            yield return new LogResult(
                "Parameter Values:\n" +
                "DataContext: {0}\n" +
                "Title: {1}\n" +
                "Args: {2}\n" +
                "Title Foreground: {3}\n" +
                "Title: {4}\n" +
                "BoolValue: {5}",
                dataContext,
                title,
                eventArgs,
                binding,
                content,
                b);
        }
    }
}