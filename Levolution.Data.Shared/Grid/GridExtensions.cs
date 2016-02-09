using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Levolution.Data
{
    public static class GridExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static IGridItem<T> GetItem<T>(this IEnumerable<IGridItem<T>> items, T row, T column)
            => items.FirstOrDefault(x => x.Row.Equals(row) && x.Column.Equals(column));
    }
}
