using System;
using System.Collections.Generic;
using Caliburn.Micro.Contrib.Decorators;
using Caliburn.Micro.Contrib.Results;

namespace Caliburn.Micro.Contrib.Helper
{
    internal class RescueHandler<T> : IExceptionHandler<T>
        where T : Exception
    {
        public RescueHandler(IResult inner)
        {
            Inner = inner;
        }

        public IResult Inner { get; private set; }
        public IResult Decorator { get; private set; }

        #region IExceptionHandler<T> Members

        public IResult With(Action<T> action, bool cancelResult = true)
        {
            Func<T, IEnumerable<IResult>> func = e => new[] {new DelegateResult(() => action(e))};

            return With(func, cancelResult);
        }

        public IResult With(Func<T, IEnumerable<IResult>> coroutine, bool cancelResult = true)
        {
            Decorator = new RescueResultDecorator<T>(Inner, coroutine, cancelResult);

            return Decorator;
        }

        #endregion
    }
}