using System.Collections;
using System.Collections.Generic;

namespace Caliburn.Micro.Contrib
{
    /// <summary>
    ///   An Enumerator which returns exactly one result
    /// </summary>
    public class SingleResultEnumerator : IEnumerator<IResult>
    {
        private readonly IResult _result;
        private bool _moved;

        public SingleResultEnumerator(IResult result)
        {
            _result = result;
        }

        #region IEnumerator<IResult> Members

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (!_moved)
            {
                _moved = true;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _moved = false;
        }

        public IResult Current
        {
            get
            {
                if (_moved) return _result;

                return null;
            }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        #endregion
    }
}