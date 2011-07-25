using System.Collections.Generic;
using Caliburn.Micro;
using Caliburn.Micro.Contrib;
using Caliburn.Micro.Contrib.Interaction;

namespace CMContrib.SL.Demo
{
    using System.ComponentModel.Composition;

    [Export(typeof(IShell))]
    public class ShellViewModel : PropertyChangedBase, IShell
    {
        public object Response { get; set; }

        public IEnumerable<IResult> Foo()
        {
            var warning = new Warning("abc", Answer.Retry, Answer.Ignore);

            yield return warning.AsResult();

            Response = warning.GivenResponse;
        }
    }
}
