using System.Threading;

namespace Caliburn.Micro.Contrib
{
    public class ResultSynchronizationContext : SynchronizationContext
    {
        readonly IBlockingQueue<ResultExecutionTask> _queue;
        readonly ResultExecutionThread _worker;

        static ResultSynchronizationContext _syncContext;

        internal ResultExecutionThread Worker
        {
            get { return _worker; }
        }

        internal IBlockingQueue<ResultExecutionTask> Queue
        {
            get { return _queue; }
        }

        public static ResultSynchronizationContext Instance
        {
            get
            {
                return _syncContext
                       ?? (_syncContext = new ResultSynchronizationContext());
            }    
        }
        
        public ResultSynchronizationContext()
        {
            _queue = new BlockingQueue<ResultExecutionTask>();
            _worker = new ResultExecutionThread(_queue);
            _worker.Start();
        }

        public override void Send(SendOrPostCallback d, object state)
        {
            ResultExecutionTask task = state as ResultExecutionTask;
            _queue.Enqueue(task);

            task.ExecutionCompleteWaitHandle.WaitOne();

            d(state);
        }

        public override void Post(SendOrPostCallback d, object state)
        {
            ResultExecutionTask task = state as ResultExecutionTask;
            task.Result.Completed += (sender, args) =>
            {
                d(state);
            };
            _queue.Enqueue(task);
        }

        public void Dispose()
        {
            _queue.Stop();
            _worker.Join();
        }

        public override SynchronizationContext CreateCopy()
        {
            return this;
        }
    }
}