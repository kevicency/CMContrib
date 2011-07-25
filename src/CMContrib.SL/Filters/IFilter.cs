namespace Caliburn.Micro.Contrib.Filters
{
    public interface IFilter
    {
        /// <summary>
        ///   Priority of the Filter. Filters with high priority get applied before filters with low priority
        /// </summary>
        int Priority { get; set; }
    }
}