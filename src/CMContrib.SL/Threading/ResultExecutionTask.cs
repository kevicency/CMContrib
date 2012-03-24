using System;
using System.Threading;

namespace Caliburn.Micro.Contrib
{
    /// <summary>
    ///  A task that is used by the <see cref="ResultSynchronizationContext"/> to store pending result executions in a queue.
    ///  The <see cref="ExecutionCompleteWaitHandle"/> is set when the result completed
    /// </summary>
    internal class ResultExecutionTask 
    {
        public ResultExecutionTask(IResult result, ActionExecutionContext context)
        {
            Result = result;
            Context = context;
            CompletionEventArgs = new ResultCompletionEventArgs();
            ExecutionCompleteWaitHandle = new ManualResetEvent(false);
        }

        IResult Result { get; set; }
        ActionExecutionContext Context { get; set; }
        public ResultCompletionEventArgs CompletionEventArgs { get; set; }
        public ManualResetEvent ExecutionCompleteWaitHandle { get; private set; }

        /// <summary>
        ///  Execute the Result
        /// </summary>
        public void Execute()
        {
            Result.Completed += OnResultCompleted;

            Result.Execute(Context);
            ExecutionCompleteWaitHandle.WaitOne();
        }

        void OnResultCompleted(object sender, ResultCompletionEventArgs e)
        {
            Result.Completed -= OnResultCompleted;
            CompletionEventArgs = e;
            ExecutionCompleteWaitHandle.Set();
            Completed(this, EventArgs.Empty);
        }

        public event EventHandler Completed = delegate { };
    }
}