using System;
using System.Collections.Generic;
using System.Text;

namespace Levolution.Data.Plane
{
    /// <summary>
    /// 
    /// </summary>
    public static class RectangeExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rect"></param>
        /// <returns></returns>
        public static IPoint<T> GetPoint<T>(this IRectangle<T> rect)
            => new PointInternal<T>(rect.X, rect.Y);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rect"></param>
        /// <returns></returns>
        public static ISize<T> GetSizet<T>(this IRectangle<T> rect)
            => new SizeInternal<T>(rect.Width, rect.Height);

        private class PointInternal<T> : IPoint<T>
        {
            public T X { get; }

            public T Y { get; }

            public PointInternal(T x, T y)
            {
                X = x;
                Y = y;
            }
        }

        private class SizeInternal<T> : ISize<T>
        {
            public T Width { get; }

            public T Height { get; }

            public SizeInternal(T width, T height)
            {
                Width = width;
                Height = height;
            }
        }
    }
}
