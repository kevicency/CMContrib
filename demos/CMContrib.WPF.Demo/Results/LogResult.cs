using System;
using System.ComponentModel.Composition;
using System.Linq;

namespace Caliburn.Micro.Contrib.Demo.Results
{
    public class LogResult : IResult
    {
        private readonly string _format;
        object[] _args;

        public LogResult(string format, params object[] args)
        {
            this._format = format;
            _args = args ?? new object[0];
        }

        [Import]
        public IShell Shell { get; set; }

        public void Execute(ActionExecutionContext context)
        {
            var message = _args.Any()
                              ? string.Format(_format, _args)
                              : _format;

            Shell.Log(message);

            Completed(this, new ResultCompletionEventArgs());
        }

        public event EventHandler<ResultCompletionEventArgs> Completed;
    }
}