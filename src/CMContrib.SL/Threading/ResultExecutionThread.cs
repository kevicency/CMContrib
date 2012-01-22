using System.Threading;

namespace Caliburn.Micro.Contrib
{
    internal class ResultExecutionThread
    {
        readonly Thread _worker;
        readonly IBlockingQueue<ResultExecutionTask> _taskQueue;

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