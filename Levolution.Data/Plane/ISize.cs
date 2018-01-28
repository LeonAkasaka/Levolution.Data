namespace Levolution.Data.Plane
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISize<T>
    {
        /// <summary>
        /// 
        /// </summary>
        T Width { get; }

        /// <summary>
        /// 
        /// </summary>
        T Height { get; }
    }
}