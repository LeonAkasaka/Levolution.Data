using System.Collections.Generic;
using System.Linq;

namespace Levolution.Data.Identity
{
    /// <summary>
    /// 
    /// </summary>
    public static class IIdentifiableExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="e"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static TResult GetById<T, TResult>(this IEnumerable<TResult> items, T id) where TResult : IIdentifiable<T>
            => items.FirstOrDefault(x => x.Id.Equals(id));

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static T GetMinId<T>(this IEnumerable<IIdentifiable<T>> items)
            => items.Min(x => x.Id);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static T GetMaxId<T>(this IEnumerable<IIdentifiable<T>> items)
            => items.Max(x => x.Id);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static IEnumerable<T> GetIds<T>(this IEnumerable<IIdentifiable<T>> items)
            => items.Select(x => x.Id).Distinct();
    }
}
