namespace Levolution.Data.Plane
{
    public struct Point<T> : IPoint<T>
    {
        public T X { get; }

        public T Y { get; }

        public Point(T x, T y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj) => obj is Point<T> pt ? this == pt : false;

        public override int GetHashCode() => X.GetHashCode() ^ Y.GetHashCode();

        public override string ToString() => $"{nameof(X)}={X}, {nameof(Y)}={Y}";


        public static bool operator ==(Point<T> a, Point<T> b) => a.X.Equals(b.X) && a.Y.Equals(b.Y);

        public static bool operator !=(Point<T> a, Point<T> b) => !(a == b);
    }
}
