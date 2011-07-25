
namespace Caliburn.Micro.Contrib.Interaction
{
    public interface IBusyIndicator
    {
        void Busy(string message);
        void Idle();
    }
}
