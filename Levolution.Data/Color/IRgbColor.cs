namespace Levolution.Data.Color
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRgbColor<T>
    {
        /// <summary>
        /// 
        /// </summary>
        T A { get; }

        /// <summary>
        /// 
        /// </summary>
        T R { get; }

        /// <summary>
        /// 
        /// </summary>
        T G { get; }

        /// <summary>
        /// 
        /// </summary>
        T B { get; }
    }
}
