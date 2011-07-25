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
        public IResult Decorator { get; private set; }

        #region ICancelledHandler Members

        public IResult Execute(System.Action action)
        {
            return Execute(new DelegateResult(action).AsCoroutine());
        }

        public IResult Execute(IEnumerable<IResult> coroutine)
        {
            Decorator = new ContinueResultDecorator(Inner, coroutine);

            return Decorator;
        }

        #endregion
    }
}