using System;

namespace Levolution.Data.Range
{
    /// <summary>
    /// 
    /// </summary>
    public static class RangeExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="range"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsInRange<T>(this T value, IRange<T> range) where T : IComparable<T>
            => value.CompareTo(range.Minimun) >= 0 && value.CompareTo(range.Maximum) <= 0;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public static T GetRangeValue<T>(this T value, IRange<T> range) where T : IComparable<T>
            => value.CompareTo(range.Minimun) < 0 ? range.Minimun
                : value.CompareTo(range.Maximum) > 0 ? range.Maximum
                : value;
    }
}
