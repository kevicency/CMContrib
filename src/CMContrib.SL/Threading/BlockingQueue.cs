using System.Collections.Generic;
using System.Threading;

namespace Caliburn.Micro.Contrib
{
    /// <summary>
    ///  When a consumer thread is dequeuing an item, one is returned if available.
    ///  Otherwise, the thread waits on the monitor. When an item is enqueued, the monitor is pulsed,
    ///  which wakes up one of the consumer threads, which dequeues the item and returns it.
    ///  Taken from http://element533.blogspot.com/2010/01/stoppable-blocking-queue-for-net.html
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BlockingQueue<T> : IBlockingQueue<T>
    {
        readonly Queue<T> _queue = new Queue<T>();
        bool _stopped;

        #region IBlockingQueue<T> Members

        /// <summary>
        /// Number of items in the queue
        /// </summary>
        public int Count
        {
            get
            {
                lock (_queue)
                {
                    return _queue.Count;
                }
            }
        }

        /// <summary>
        ///  Adds an item to the queue and pulses all waiting threads
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Enqueue(T item)
        {
            if (_stopped) return false;
            lock (_queue)
            {
                if (_stopped) return false;
                _queue.Enqueue(item);
                Monitor.Pulse(_queue);
            }
            return true;
        }

        /// <summary>
        ///  Returns the next item from the queue. If the queue is empty,the threads waits for new items.
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (_stopped) return default(T);
            lock (_queue)
            {
                if (_stopped) return default(T);
                while (_queue.Count == 0)
                {
                    Monitor.Wait(_queue);
                    if (_stopped) return default(T);
                }
                return _queue.Dequeue();
            }
        }

        /// <summary>
        ///  Stops the queue and pulses all waiting threads.
        /// </summary>
        public void Stop()
        {
            if (_stopped) return;
            lock (_queue)
            {
                if (_stopped) return;
                _stopped = true;
                Monitor.PulseAll(_queue);
            }
        }

        #endregion
    }
}