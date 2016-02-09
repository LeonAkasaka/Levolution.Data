using System;
using System.Collections.Generic;
using System.Text;

namespace Levolution.Data
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
