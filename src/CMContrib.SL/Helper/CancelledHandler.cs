using System;
using System.Collections.Generic;
using Caliburn.Micro.Contrib.Decorators;
using Caliburn.Micro.Contrib.Results;

namespace Caliburn.Micro.Contrib.Helper
{
    internal class CancelledHandler : ICancelledHandler
    {
        public CancelledHandler(IResult inner)
        {
            Inner = inner;
        }

        public IResult Inner { get; private set; }

        #region ICancelledHandler Members

        public IResult Invoke(System.Action action)
        {
            return Execute(() => new DelegateResult(action).AsCoroutine());
        }

        public IResult Execute(Func<IEnumerable<IResult>> coroutine)
        {
            return new ContinueResultDecorator(Inner, coroutine);
        }

        public IResult Override()
        {
            return new OverrideCancelResultDecorator(Inner);
        }

        #endregion
    }
}