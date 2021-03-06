﻿namespace Levolution.Data.Identity
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IIdentifiable<out T>
    {
        /// <summary>
        /// 
        /// </summary>
        T Id { get; }
    }

    /// <summary>
    /// 
    /// </summary>
    public interface IIdentifiable : IIdentifiable<int> { }
}
