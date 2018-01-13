namespace Levolution.Data.Converter
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TOutput"></typeparam>
    public interface IInvertibleConverter<TInput, TOutput> : IConverter<TInput, TOutput>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        TInput ConvertBack(TOutput value);
    }
}
