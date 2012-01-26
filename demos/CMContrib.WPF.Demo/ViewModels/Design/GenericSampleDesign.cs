using System.Collections.Generic;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Design
{
    public class GenericSampleDesign : SampleScreen
    {
        public GenericSampleDesign()
        {
            DisplayName = "Design Sample";
            Description =
               "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
            
        }
        public override IEnumerable<IResult> Execute()
        {
            yield break;
        }
    }
}