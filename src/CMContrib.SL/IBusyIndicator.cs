
namespace Caliburn.Micro.Contrib
{
    public interface IBusyIndicator
    {
        void Busy(string message);
        void Idle();
    }
}
