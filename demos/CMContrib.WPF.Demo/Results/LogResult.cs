using System;

namespace Caliburn.Micro.Contrib.WPF.Demo.Results
{
    public class LogResult : IResult
    {
        private readonly string _message;

        public LogResult(string message)
        {
            this._message = message;
        }

        public IShell Shell { get; set; }

        public void Execute(ActionExecutionContext context)
        {
            IoC.Get<IShell>().Log(_message);
            Completed(this, new ResultCompletionEventArgs());
        }

        public event EventHandler<ResultCompletionEventArgs> Completed;
    }
}