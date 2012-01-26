using System.Collections.Generic;

namespace Caliburn.Micro.Contrib.Demo
{
    public interface ISample : IHaveDisplayName
    {
        SampleCategory Category { get; }
        string Description { get; }
        string Code { get; }
        string ExecuteMessage { get; }

        IEnumerable<IResult> Execute();
    }
}