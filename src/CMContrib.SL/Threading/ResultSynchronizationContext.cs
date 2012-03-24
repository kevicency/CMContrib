using System.Threading;

namespace Caliburn.Micro.Contrib
{
    /// <summary>
    /// Implementation of the <see cref="SynchronizationContext"/> to execute Results in a background worker thread.
    /// Uses a <see cref="IBlockingQueue{T}"/> to store pending result executions and a <see cref="ResultExecutionThread"/>
    /// to execute the Results. Since there should only be one worker thread, the <see cref="ResultSynchronizationContext"/>
    /// implements the Singleton Pattern.
    /// </summary>
    public class ResultSynchronizationContext : SynchronizationContext
    {
        static ResultSynchronizationContext _instance;
        static readonly object _lock = new object();
        readonly IBlockingQueue<ResultExecutionTask> _queue;
        readonly ResultExecutionThread _worker;

        ResultSynchronizationContext()
        {
            _queue = new BlockingQueue<ResultExecutionTask>();
            _worker = new ResultExecutionThread(_queue);
            _worker.Start();
        }

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
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ResultSynchronizationContext();
                    }
                    return _instance;
                }
            }
        }

        public override void Send(SendOrPostCallback d, object state)
        {
            var task = state as ResultExecutionTask;
            _queue.Enqueue(task);

            task.ExecutionCompleteWaitHandle.WaitOne();

            d(state);
        }

        public override void Post(SendOrPostCallback d, object state)
        {
            var task = state as ResultExecutionTask;
            task.Completed += (sender, args) => d(state);
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