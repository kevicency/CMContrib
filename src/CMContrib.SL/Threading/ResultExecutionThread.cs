using System.Threading;

namespace Caliburn.Micro.Contrib
{
    /// <summary>
    ///  Wraps a background thread that is used by the <see cref="ResultSynchronizationContext"/> to execute Results
    /// </summary>
    internal class ResultExecutionThread
    {
        readonly IBlockingQueue<ResultExecutionTask> _taskQueue;
        readonly Thread _worker;

        public ResultExecutionThread(IBlockingQueue<ResultExecutionTask> taskQueue)
        {
            _taskQueue = taskQueue;
            _worker = new Thread(Run)
                      {
                          Name = "Result Worker Thread",
                          IsBackground = true
                      };
#if !SILVERLIGHT
            _worker.SetApartmentState(ApartmentState.STA);
#endif
        }

        public void Start()
        {
            _worker.Start();
        }


        internal void Join()
        {
            _worker.Join();
        }

        void Run()
        {
            ResultExecutionTask task;
            while ((task = _taskQueue.Dequeue()) != null)
            {
                task.Execute();
            }
        }
    }
}