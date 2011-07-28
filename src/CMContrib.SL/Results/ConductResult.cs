using System;
using System.Collections.Generic;

namespace Caliburn.Micro.Contrib.Results
{
    public class ConductResult<TItem> : OpenResultBase<TItem>
    {
        private readonly Func<ActionExecutionContext, TItem> _locateItem = c => IoC.Get<TItem>();
        private Func<ActionExecutionContext, IConductor> _locateConductor = c => (IConductor) c.Target;

        public ConductResult()
        {
        }

        public ConductResult(TItem item)
        {
            _locateItem = c => item;
        }

        private IEnumerable<IResult> ActivateItem(IConductor parent, TItem item)
        {
            if (OpenResult.BeforeActivation != null) yield return new SequentialResult(OpenResult.BeforeActivation(item).GetEnumerator());

            yield return new DelegateResult(() => parent.ActivateItem(item));

            if (OpenResult.AfterActivation != null) yield return new SequentialResult(OpenResult.AfterActivation(item).GetEnumerator());
        }

        private void AddCloseHandlers(TItem item, ActionExecutionContext context)
        {
            var deactivateable = item as IDeactivate;
            if (deactivateable == null) return;

            if (OpenResult.BeforeClosing != null)
            {
                EventHandler<DeactivationEventArgs> deactivating = null;
                deactivating = (sender, args) =>
                               {
                                   if (args.WasClosed)
                                   {
                                       (sender as IDeactivate).AttemptingDeactivation -= deactivating;

                                       Coroutine.BeginExecute(OpenResult.BeforeClosing(item).GetEnumerator(), context);
                                   }
                               };
                deactivateable.AttemptingDeactivation += deactivating;
            }
            if (OpenResult.AfterClosing != null)
            {
                EventHandler<DeactivationEventArgs> deactivated = null;
                deactivated = (sender, args) =>
                              {
                                  if (args.WasClosed)
                                  {
                                      (sender as IDeactivate).Deactivated -= deactivated;

                                      Coroutine.BeginExecute(OpenResult.AfterClosing(item).GetEnumerator(), context);
                                  }
                              };
                deactivateable.Deactivated += deactivated;
            }
        }

        protected override void Execute(ActionExecutionContext context)
        {
            IConductor conductor = _locateConductor(context);
            TItem item = _locateItem(context);

            AddCloseHandlers(item, context);

            Coroutine.BeginExecute(ActivateItem(conductor, item).GetEnumerator(),
                                   context,
                                   (sender, args) => OnCompleted(args.Error, args.WasCancelled));
        }

        public ConductResult<TItem> In<TParent>()
            where TParent : IConductor
        {
            _locateConductor = c => IoC.Get<TParent>();

            return this;
        }

        public ConductResult<TItem> In<TParent>(TParent parent)
            where TParent : IConductor
        {
            _locateConductor = c => parent;

            return this;
        }
    }
}