namespace Levolution.Data.Grid
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGridItem<T>
    {
        /// <summary>
        /// 
        /// </summary>
        T Row { get; }

        /// <summary>
        /// 
        /// </summary>
        T Column { get; }
    }

    /// <summary>
    /// 
    /// </summary>
    public interface IGridItem : IGridItem<int> { }
}
