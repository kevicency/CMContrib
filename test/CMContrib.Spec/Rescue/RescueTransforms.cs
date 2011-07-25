using System;
using Caliburn.Micro;
using TechTalk.SpecFlow;

namespace CMContrib.Spec.Rescue
{
    [Binding]
    public class RescueTransforms
    {
        [StepArgumentTransformation(
            @"(completes|gets cancelled|fails|fails with)(.*)")]
        public ResultCompletionEventArgs ResultCompletitionTransform(string s, string error)
        {
            var args = new ResultCompletionEventArgs();

            if (s.Contains("cancel"))
                args.WasCancelled = true;
            else if (s.Contains("error"))
                args.Error = RescueContext.ArbitraryException;
            else if (s.Contains("fails"))
                args.Error = ParseError(error);

            return args;
        }

        private Exception ParseError(string error)
        {
            var ex = new Exception();
            if (!String.IsNullOrWhiteSpace(error))
            {
                var type = Type.GetType(error);
                if (type != null) ex = Activator.CreateInstance(type) as Exception;
            }

            return ex;
        }
    }
}