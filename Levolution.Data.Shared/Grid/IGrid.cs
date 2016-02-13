using System.Collections.Generic;

namespace Levolution.Data.Grid
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGrid<T>
    {
        /// <summary>
        /// 
        /// </summary>
        T Rows { get; }

        /// <summary>
        /// 
        /// </summary>
        T Columns { get; }

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<IGridItem<T>> Items { get; }
    }

    /// <summary>
    /// 
    /// </summary>
    public interface IGrid : IGrid<int> { }
}
