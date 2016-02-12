using System;
using System.Collections.Generic;
using System.Text;

namespace Levolution.Data.Shared.Converter
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TOutput"></typeparam>
    public interface IConverter<TInput, TOutput>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        TOutput Convert(TInput value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        TInput ConvertBack(TOutput value);
    }
}
