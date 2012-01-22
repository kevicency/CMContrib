namespace Caliburn.Micro.Contrib.Results
{
    public interface IBusyResult:IResult
    {
        IBusyResult In<T>()
            where T : IBusyIndicator;

        IBusyResult In(IBusyIndicator busyIndicator);
    }
}