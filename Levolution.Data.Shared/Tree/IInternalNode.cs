using System;
using System.Collections.Generic;
using System.Text;

namespace Levolution.Data
{
    /// <summary>
    /// 
    /// </summary>
    public interface IInternalNode : INode
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<INode> Children { get; }
    }
}
