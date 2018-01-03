using System;
using System.Collections.Generic;
using System.Text;

namespace Levolution.Data.Plane
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPoint<T>
    {
        /// <summary>
        /// 
        /// </summary>
        T X { get; }

        /// <summary>
        /// 
        /// </summary>
        T Y { get; }
    }
}
