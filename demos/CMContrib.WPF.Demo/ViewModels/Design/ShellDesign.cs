using System.Collections.Generic;
using System.ComponentModel;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Design
{
    public class CategoryDesign : INotifyPropertyChanged
    {
        public SampleCategory Category { get; set; }
        public ISample ActiveItem { get; set; }
        public IObservableCollection<ISample> Items { get; set; } 
        public int ActiveIndex { get; private set; }
        public IObservableCollection<string> NextSamples { get; set; }

        public CategoryDesign()
        {
            Category = SampleCategory.Dialogs;
            Items = new BindableCollection<ISample> {new GenericSampleDesign(), new GenericSampleDesign()};
            NextSamples= new BindableCollection<string>(){"Foo", "Bar"};
            ActiveItem = Items[0];
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class ShellDesign : Conductor<ISample> ,IShell
    {
        public ShellDesign()
        {
            DisplayName = "CMContrib";
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