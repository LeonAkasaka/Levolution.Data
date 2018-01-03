using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Levolution.Data.Timeline
{
    public static class TimelineExtensions
    {
        public static Task AsTask(this ITimeline timeline)
        {
            if (timeline.CurrentState == TimelineState.Stopped)
            {
                return Task.FromResult<object>(null);
            }

            var tcs = new TaskCompletionSource<object>();
            EventHandler h = null;
            h += (sender, args) =>
            {
                timeline.CurrentStateChanged -= h;
                tcs.SetResult(null);
            };
            timeline.CurrentStateChanged += h;
            return tcs.Task;
        }
    }
}
