using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Caliburn.Micro.Contrib.Interaction;

namespace Caliburn.Micro.Contrib.Results
{
    public class BusyResult : IResult
    {
        private readonly bool _show;
        private readonly string _message;

        public BusyResult(bool show, string message = null)
        {
            _message = message;
            _show = show;
        }

        #region IResult Members

        public void Execute(ActionExecutionContext context)
        {
            Micro.Execute.OnUIThread(() => InnerExecute(context));
        }

        public event EventHandler<ResultCompletionEventArgs> Completed = delegate { };

        #endregion

        public static BusyResult Show(string message)
        {
            return new BusyResult(true, message);
        }

        public static BusyResult Hide()
        {
            return new BusyResult(false);
        }

        private void InnerExecute(ActionExecutionContext context)
        {
            var view = context.View as FrameworkElement;

            //bottom up search
            while (view != null)
            {
                var indicator = view as IBusyIndicator;
                if (indicator != null)
                {
                    if (_show)
                    {
                        indicator.Busy(_message);
                    }
                    else
                    {
                        indicator.Idle();
                    }
                    break;
                }
                view = view.Parent as FrameworkElement;
            }

            //top down search
            if (view == null)
            {
                var queue = new Queue<FrameworkElement>();

                queue.Enqueue(context.View as FrameworkElement);
                if (!TopDownSearch(queue))
                {
#if SILVERLIGHT
                    queue.Enqueue(Application.Current.RootVisual as FrameworkElement);
#elif WPF
                    queue.Enqueue(Application.Current.MainWindow);
#endif
                    TopDownSearch(queue, context.View as FrameworkElement);
                }
            }

            Completed(this, new ResultCompletionEventArgs());
        }

        private bool TopDownSearch(Queue<FrameworkElement> queue, params FrameworkElement[] toIgnore)
        {
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current == null || toIgnore.Contains(current)) continue;

                var indicator = current as IBusyIndicator;
                if (indicator != null)
                {
                    if (_show)
                    {
                        indicator.Busy(_message);
                    }
                    else
                    {
                        indicator.Idle();
                    }
                    return true;
                }

                var count = VisualTreeHelper.GetChildrenCount(current);
                for (var i = 0; i < count; i++)
                {
                    queue.Enqueue(VisualTreeHelper.GetChild(current, i) as FrameworkElement);
                }
            }

            return false;
        }
    }
}