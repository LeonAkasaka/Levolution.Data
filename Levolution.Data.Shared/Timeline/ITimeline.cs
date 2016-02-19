using System;

namespace Levolution.Data.Timeline
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITimeline
    {
        /// <summary>
        /// 
        /// </summary>
        double Progress { get; }

        /// <summary>
        /// 
        /// </summary>
        event EventHandler ProgressChanged;

        /// <summary>
        /// 
        /// </summary>
        TimelineState CurrentState { get; }

        /// <summary>
        ///
        /// </summary>
        event EventHandler CurrentStateChanged;
    }
}
