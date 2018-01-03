using System;
using System.Collections.Generic;
using System.Text;

namespace Levolution.Data.Tree
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITreeItem
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<ITreeItem> Items { get; }
    }
}
