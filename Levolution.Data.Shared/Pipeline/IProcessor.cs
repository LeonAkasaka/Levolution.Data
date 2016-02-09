using System;
using System.Collections.Generic;
using System.Text;

namespace Levolution.Data
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TOutput"></typeparam>
    public interface IProcessor<TInput, TOutput>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        TOutput Execute(TInput input);
    }
}
