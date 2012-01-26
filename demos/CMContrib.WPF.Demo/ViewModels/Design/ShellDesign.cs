using System.Collections.Generic;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Design
{
    public class ShellDesign : Conductor<ISample> ,IShell
    {
        public ShellDesign()
        {
            SamplesByCategory = new BindableCollection<CategorySamples>();
            SamplesByCategory.Add(new CategorySamples(SampleCategory.Coroutine, new List<ISample>
                                            {
                                                new GenericSampleDesign(),
                                                new GenericSampleDesign()
                                            }));
            SamplesByCategory.Add(new CategorySamples(SampleCategory.Dialogs, new List<ISample>
                                            {
                                                new GenericSampleDesign(),
                                                new GenericSampleDesign()
                                            }));
            ActiveItem = new GenericSampleDesign();
        }

        public IObservableCollection<CategorySamples> SamplesByCategory { get; private set; }

        public IObservableCollection<string> LogItems
        {
            get
            {
                return new BindableCollection<string>
                       {
                           "Foo",
                           "Bar",
                           "Baz",
                           "Foo",
                           "Bar",
                           "Baz"
                       };
            }
        }

        public void Log(string message)
        {
            
        }
    }
}