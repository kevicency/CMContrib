using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Caliburn.Micro.Contrib.Demo.Results;
using Caliburn.Micro.Contrib.Results;

namespace Caliburn.Micro.Contrib.Demo.ViewModels.Samples
{
    [Export(typeof(ISample))]
    public class RescueExtensionViewModel : SampleScreen
    {
        public RescueExtensionViewModel()
        {
            Category = SampleCategory.Coroutine;
            Description = "The Rescue Extension Method can be used to decorate IResults. " +
               "The decorator that catches all thrown exceptions as well as errors in the ResultCompletitionEventArgs of the result. " +
               "The rescue decorator either takes a coroutine or a method that is executed/invoked if an exception is catched";
        }

        public override IEnumerable<IResult> Execute()
        {
            var ex = new Exception("General Exception");
            var argEx = new ArgumentException("Specific Exception");

            yield return new CompleteWithErrorResult(ex)
                .Rescue().Execute(
                    x => new LogResult("Rescued Error with Coroutine: {0} - {1}",
                                       x.GetType(),
                                       x.Message)
                             .AsEnumerable(),
                    false);

            yield return new CompleteWithErrorResult(argEx)
                .Rescue<ArgumentException>().Execute(
                    x => new LogResult("Rescued Error with Coroutine: {0} - {1}",
                                       x.GetType(),
                                       x.Message).
                             AsEnumerable(),
                    false);

            yield return new CompleteWithErrorResult(ex)
                .Rescue().Invoke(
                    x => IoC.Get<IShell>()
                             .Log(string.Format("Rescued Error with action: {0} - {1}",
                                                x.GetType(),
                                                x.Message)),
                    false);

            yield return new DelegateResult(() => { throw argEx; })
                .Rescue<ArgumentException>().Execute(
                    x => new LogResult("Rescued thrown Exception with Coroutine: {0} - {1}",
                                       x.GetType(),
                                       x.Message).
                             AsEnumerable());
        }
    }
}