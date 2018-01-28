namespace Levolution.Data.Plane
{
    public struct Size<T> : ISize<T>
    {
        public T Width { get; }
        public T Height { get; }

        public Size(T width, T height)
        {
            Width = width;
            Height = height;
        }

        public override bool Equals(object obj) => obj is Size<T> size ? this == size : false;

        public override int GetHashCode() => Width.GetHashCode() ^ Height.GetHashCode();

        public override string ToString() => $"{nameof(Width)}={Width}, {nameof(Height)}={Height}";
        
        public static bool operator ==(Size<T> a, Size<T> b) => a.Width.Equals(b.Width) && a.Height.Equals(b.Height);

        public static bool operator !=(Size<T> a, Size<T> b) => !(a == b);
    }
}
