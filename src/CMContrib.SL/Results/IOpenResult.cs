using System;
using System.Collections.Generic;

namespace Caliburn.Micro.Contrib.Results
{
    public interface IOpenResult<TTarget> : IResult
    {
        Func<TTarget, IEnumerable<IResult>> BeforeActivation { get; set; }
        Func<TTarget, IEnumerable<IResult>> AfterActivation { get; set; }
        Func<TTarget, IEnumerable<IResult>> BeforeClosing { get; set; }
        Func<TTarget, IEnumerable<IResult>> AfterClosing { get; set; }
    }
}