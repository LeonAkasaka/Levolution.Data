using System;
using System.Collections.Generic;
using System.Text;

namespace Levolution.Data.Plane
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRectangle<T>
    {
        /// <summary>
        /// 
        /// </summary>
        T X { get; }

        /// <summary>
        /// 
        /// </summary>
        T Y { get; }

        /// <summary>
        /// 
        /// </summary>
        T Width { get; }

        /// <summary>
        /// 
        /// </summary>
        T Height { get; }
    }
}
