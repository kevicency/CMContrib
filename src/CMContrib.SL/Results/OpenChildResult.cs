using System;

namespace Caliburn.Micro.Contrib.Results
{
    public class OpenChildResult<TChild> : OpenResultBase<TChild>
    {
        private readonly Func<ActionExecutionContext, TChild> locateChild = c => IoC.Get<TChild>();
        private Func<ActionExecutionContext, IConductor> locateParent = c => (IConductor) c.Target;

        public OpenChildResult()
        {
        }

        public OpenChildResult(TChild child)
        {
            locateChild = c => child;
        }

        private void SafeExecute(IResult result, ActionExecutionContext context)
        {
            result
                .Rescue().With(x => OnCompleted(x, false))
                .WhenCancelled().Execute(() => OnCompleted(null, true))
                .BlockingExecute(context);
        }

        protected override void Execute(ActionExecutionContext context)
        {
            IConductor parent = locateParent(context);
            TChild child = locateChild(context);

            if (OpenResult.BeforeActivation != null)
            {
                var coroutine = new SequentialResult(OpenResult.BeforeActivation(child).GetEnumerator());
                SafeExecute(coroutine, context);
            }

            EventHandler<ActivationProcessedEventArgs> processed = null;
            processed = (s, e) =>
                        {
                            parent.ActivationProcessed -= processed;

                            if (e.Success)
                            {
                                if (OpenResult.AfterActivation != null)
                                {
                                    var coroutine =
                                        new SequentialResult(OpenResult.AfterActivation(child).GetEnumerator());
                                    SafeExecute(coroutine, context);
                                }

                                var deactivator = child as IDeactivate;

                                if (deactivator != null)
                                {
                                    if (OpenResult.BeforeClosing != null)
                                    {
                                        EventHandler<DeactivationEventArgs> handler = null;
                                        handler = (s2, e2) =>
                                                  {
                                                      if (!e2.WasClosed) return;

                                                      deactivator.AttemptingDeactivation -= handler;
                                                      if (OpenResult.BeforeClosing != null)
                                                      {
                                                          var coroutine =
                                                              new SequentialResult(
                                                                  OpenResult.BeforeClosing(child).GetEnumerator());
                                                          SafeExecute(coroutine, context);
                                                      }
                                                  };

                                        deactivator.AttemptingDeactivation += handler;
                                    }

                                    if (OpenResult.AfterClosing != null)
                                    {
                                        EventHandler<DeactivationEventArgs> handler = null;
                                        handler = (s2, e2) =>
                                                  {
                                                      if (!e2.WasClosed) return;

                                                      deactivator.Deactivated -= handler;
                                                      if (OpenResult.AfterClosing != null)
                                                      {
                                                          var coroutine =
                                                              new SequentialResult(
                                                                  OpenResult.AfterClosing(child).GetEnumerator());
                                                          SafeExecute(coroutine, context);
                                                      }
                                                  };

                                        deactivator.Deactivated += handler;
                                    }
                                }

                                OnCompleted(null, false);
                            }
                            else OnCompleted(null, true);
                        };

            parent.ActivationProcessed += processed;
            parent.ActivateItem(child);
        }

        public OpenChildResult<TChild> In<TParent>()
            where TParent : IConductor
        {
            locateParent = c => IoC.Get<TParent>();

            return this;
        }

        public OpenChildResult<TChild> In<TParent>(TParent parent)
            where TParent : IConductor
        {
            locateParent = c => parent;

            return this;
        }
    }
}