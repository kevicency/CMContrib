namespace Caliburn.Micro.Contrib
{
    public interface IBlockingQueue<T>
    {
        int Count { get; }
        bool Enqueue(T item);
        T Dequeue();
        void Stop();
    }
}