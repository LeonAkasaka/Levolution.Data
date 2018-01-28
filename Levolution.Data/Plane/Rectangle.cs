using System;

namespace Levolution.Data.Plane
{
    public struct Rectangle<T> : IRectangle<T>
    {
        public T X { get; }

        public T Y { get; }

        public T Width { get; }
        public T Height { get; }

        public Rectangle(T x, T y, T width, T height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public override bool Equals(object obj) => obj is Rectangle<T> rect ? this == rect : false;

        public override int GetHashCode() => X.GetHashCode() ^ Y.GetHashCode() ^ Width.GetHashCode() ^ Height.GetHashCode();

        public override string ToString() => $"{nameof(X)}={X}, {nameof(Y)}={Y}, {nameof(Width)}={Width}, {nameof(Height)}={Height}";
        
        public static bool operator ==(Rectangle<T> a, Rectangle<T> b) => a.X.Equals(b.X) && a.Y.Equals(b.Y) && a.Width.Equals(b.Width) && a.Height.Equals(b.Height);

        public static bool operator !=(Rectangle<T> a, Rectangle<T> b) => !(a == b);
    }
}
