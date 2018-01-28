using System;

namespace Levolution.Data.Color
{
    public static class ColorExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static int ToInteger(this IRgbColor<byte> color)
            => color.A << 24 | color.R << 16 | color.G << 8 | color.B;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static IRgbColor<byte> ToRgbColor(this int color)
            => color.ToRgbColor((a, r, g, b) => new RgbColorInternal(a, r, g, b));

        public static IRgbColor<T> ToRgbColor<T>(this int color, Func<byte, byte, byte, byte, IRgbColor<T>> creator)
            => creator(GetAlpha(color), GetRed(color), GetGreen(color), GetBlue(color));
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static byte GetAlpha(int color) => (byte)(color >> 24);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static byte GetRed(int color) => (byte)(color >> 16);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static byte GetGreen(int color) => (byte)(color >> 8);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static byte GetBlue(int color) => (byte)color;

        private class RgbColorInternal : IRgbColor<byte>
        {
            public byte A { get; }
            public byte R { get; }
            public byte G { get; }
            public byte B { get; }
            
            public RgbColorInternal(byte a, byte r, byte g, byte b)
            {
                A = a;
                R = r;
                G = g;
                B = b;
            }
        }
    }
}
