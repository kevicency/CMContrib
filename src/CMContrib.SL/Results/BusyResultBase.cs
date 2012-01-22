using System;
using System.Windows;

namespace Caliburn.Micro.Contrib.Results
{
    public abstract class BusyResultBase : IBusyResult
    {
        ILog _log = LogManager.GetLog(typeof(BusyResultBase));

        protected Func<ActionExecutionContext, IBusyIndicator> _locateBusyIndicator = x => SearchVisualTree(x);

        protected static IBusyIndicator SearchVisualTree(ActionExecutionContext context)
        {
            var view = context.View as FrameworkElement;

            //bottom up search
            while (view != null)
            {
                var indicator = view as IBusyIndicator;
                if (indicator != null)
                {
                    return indicator;
                }
                view = view.Parent as FrameworkElement;
            }

            return null;
        }

        public IBusyResult In<T>()
            where T : IBusyIndicator
        {
            _locateBusyIndicator = x => IoC.Get<T>();

            return this;
        }

        public IBusyResult In(IBusyIndicator busyIndicator)
        {
            _locateBusyIndicator = x => busyIndicator;

            return this;
        }

        protected void UpdateIndicator(ActionExecutionContext context, string message)
        {
            var indicator = _locateBusyIndicator(context);

            if (indicator != null)
            {
                _log.Info("Updating Busy Indicator {0} of Type {1}", indicator, indicator.GetType());

                if (!string.IsNullOrWhiteSpace(message))
                {
                    indicator.Busy(message);
                }
                else
                {
                    indicator.Idle();
                }
            }
            else
            {
                _log.Warn("No implementation of IBusyIndicator found");
            }
        }

        public abstract void Execute(ActionExecutionContext context);

        public abstract event EventHandler<ResultCompletionEventArgs> Completed;
    }
}