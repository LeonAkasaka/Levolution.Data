using System;
using System.Collections.Generic;
using System.Text;

namespace Levolution.Data
{
    /// <summary>
    /// 
    /// </summary>
    public interface INode
    {
        /// <summary>
        /// 
        /// </summary>
        INode Parent { get; }
    }
}
