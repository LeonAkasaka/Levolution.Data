﻿namespace Levolution.Data.Range
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRange<T>
    {
        /// <summary>
        /// 
        /// </summary>
        T Minimun { get; }

        /// <summary>
        /// 
        /// </summary>
        T Maximum { get; }
    }
}
