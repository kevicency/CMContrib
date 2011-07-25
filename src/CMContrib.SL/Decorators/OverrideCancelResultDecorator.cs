namespace Caliburn.Micro.Contrib.Decorators
{
    /// <summary>
    ///   A result decorator which overrides the <see cref = "ResultCompletionEventArgs.WasCancelled" /> flag of the inner result
    /// </summary>
    internal class OverrideCancelResultDecorator : ResultDecoratorBase
    {
        private static readonly ILog _log = LogManager.GetLog(typeof(OverrideCancelResultDecorator));

        public OverrideCancelResultDecorator(IResult inner)
                : base(inner)
        { }

        private static ILog Log
        {
            get { return _log; }
        }


        protected override void InnerCompleted(object sender, ResultCompletionEventArgs args)
        {
            base.InnerCompleted(sender, args);

            if (args.WasCancelled) _log.Info(string.Format("Overriding WasCancelled from {0}", Inner.GetType().Name));

            OnCompleted(new ResultCompletionEventArgs { Error = args.Error });
        }
    }
}