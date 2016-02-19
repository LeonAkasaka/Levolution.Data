using System;
using System.Collections.Generic;
using System.Text;

namespace Levolution.Data
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRange<T>
    {
        /// <summary>
        /// 
        /// </summary>
        T Minimun { get; }

        /// <summary>
        /// 
        /// </summary>
        T Maximum { get; }
    }
}
