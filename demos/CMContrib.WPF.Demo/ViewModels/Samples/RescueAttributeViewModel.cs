using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Caliburn.Micro.Contrib.Demo.Results;
using Caliburn.Micro.Contrib.Filters;
using Caliburn.Micro.Contrib.Results;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof(ISample))]
    [Rescue(MethodName = "MyRescue")]
    public class RescueAttributeViewModel : SampleScreen
    {
        public RescueAttributeViewModel()
        {
            Category = SampleCategory.Core;
            Description = "The RescueAttribute can be used to decorate methods that return a coroutine or classes. " +
                          "The Attribute decorates the coroutine with a RescueDecorator that catches all thrown exceptions " +
                          "as well as errors in the ResultCompletitionEventArgs of the coroutine. " +
                          "If an exception is catched, the rescue method is executed";
        }

        [Rescue(MethodName = "MyRescue")]
        public override IEnumerable<IResult> Execute()
        {
            yield return new DelegateResult(() => { throw new Exception("I am evil !"); });
        }

        public IEnumerable<IResult> MyRescue(Exception ex)
        {
            yield return new LogResult("Rescued thrown Exception: {0} - {1}", ex.GetType(), ex.Message);
        }
    }
}