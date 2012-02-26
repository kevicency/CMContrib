using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

namespace Caliburn.Micro.Contrib.Demo.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class CategoryShellViewModel : Conductor<ISample>.Collection.OneActive
    {
        public SampleCategory Category { get; set; }
        public int ActiveIndex { get; private set; }

        public IObservableCollection<ISample> NextSamples { get; private set; }

        public CategoryShellViewModel()
        {
            NextSamples = new BindableCollection<ISample>();
        }

        protected override void OnActivate()
        {
            base.OnActivate();
            if (ActiveItem == null && Items.Any())
            {
                ActivateIndex(0);
            }
        }

        public IEnumerable<IResult> NextSample()
        {
            ActivateIndex(ActiveIndex + 1);

            yield break;
        }

        public IEnumerable<IResult> PreviousSample()
        {
            ActivateIndex(ActiveIndex - 1);

            yield break;
        }

        void ActivateIndex(int index)
        {
            ActiveIndex = (index + Items.Count) % Items.Count;
            ActivateItem(Items[ActiveIndex]);
            NextSamples.Clear();
            for (int i = 1; i < Items.Count; i++)
            {
                NextSamples.Add(Items[(i + ActiveIndex) % Items.Count]);
            }
        }

        public void ActivateSample(ISample item)
        {
            var index = Items.IndexOf(item);
            ActivateIndex(index);
        }
    }
}