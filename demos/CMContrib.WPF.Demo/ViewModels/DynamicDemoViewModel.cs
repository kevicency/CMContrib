using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows.Input;
using System.Windows.Media;
using Caliburn.Micro.Contrib.Demo.Results;

namespace Caliburn.Micro.Contrib.Demo.ViewModels
{
    [Export(typeof(IDemo))]
    public class DynamicDemoViewModel : Screen, IDemo
    {
        public DynamicDemoViewModel()
        {
            DisplayName = "Dynamic Demo";
        }

        public IEnumerable<IResult> ShowMessage(
            object dataContext,
            string title,
            object eventArgs,
            MouseButtonState buttonState,
            Brush binding,
            string content,
            bool b)
        {
            yield return new LogResult(string.Format(
                "Parameter Values:\nDataContext: {0}\nTitle: {1}\nArgs: {2}\nButtonState: {3}\nBinding: {4}\nButtonContent: {5}\nBoolValue: {6}",
                dataContext,
                title,
                eventArgs,
                buttonState,
                binding,
                content,
                b));
        }
    }
}