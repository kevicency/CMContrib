using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace Caliburn.Micro.Contrib.Results
{
    public class BusyResult : BusyResultBase
    {
        readonly string _message;

        internal BusyResult(string message = null)
        {
            _message = message;
        }

        #region IResult Members

        public override void Execute(ActionExecutionContext context)
        {
            Micro.Execute.OnUIThread(() => UpdateIndicator(context, _message));

            Completed(this, new ResultCompletionEventArgs());
        }

        public override event EventHandler<ResultCompletionEventArgs> Completed = delegate { };

        #endregion

        public static BusyResult Show(string message)
        {
            return new BusyResult(message);
        }

        public static BusyResult Hide()
        {
            return new BusyResult();
        }

    }
}