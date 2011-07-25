using System;
using Caliburn.Micro;

namespace CMContrib.Spec.Rescue
{
    public class RescueContext
    {
        public static readonly Exception ArbitraryException = new Exception();

        public IResult Result { get; set; }
        public Exception RescuedException { get; set; }
        public ResultCompletionEventArgs ResultCompletedArgs { get; set; }
        public bool RescueInvoked { get; set; }

     
    }
}