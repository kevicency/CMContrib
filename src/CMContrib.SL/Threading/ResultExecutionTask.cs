using System;
using System.Threading;

namespace Caliburn.Micro.Contrib
{
    internal class ResultExecutionTask
    {
        public IResult Result { get; private set; }
        public ActionExecutionContext Context { get; private set; }
        public ResultCompletionEventArgs CompletionEventArgs { get; set; }

        public ManualResetEvent ExecutionCompleteWaitHandle { get; private set; }

        public ResultExecutionTask(IResult result, ActionExecutionContext context)
        {
            Result = result;
            Context = context;
            CompletionEventArgs = new ResultCompletionEventArgs();
            ExecutionCompleteWaitHandle = new ManualResetEvent(false);
        }

        public void Execute()
        {
            Result.Completed += OnResultCompleted;

            Result.Execute(Context);
        }

        void OnResultCompleted(object sender, ResultCompletionEventArgs e)
        {
            Result.Completed -= OnResultCompleted;
            CompletionEventArgs = e;
            ExecutionCompleteWaitHandle.Set();
        }
    }
}