using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bottalino.utils
{
    public static class Interval
    {
        public static void RT(Action action, int seconds, CancellationToken token)
        {
            if (action == null)
                return; Task.Run(async () =>
                {
                    while (!token.IsCancellationRequested)
                    {
                        action();
                        await Task.Delay(TimeSpan.FromSeconds(seconds), token);
                    }
                }, token);
        }

        public static async Task<bool> RT(Func<bool> isCompletedTask, int seconds, CancellationToken token)
        {
            if (isCompletedTask == null)
                return false;
           
            return await Task.Run(async () =>
                {
                    bool isCompleted = false;
                    while (!token.IsCancellationRequested && !isCompleted)
                    {
                        isCompleted = isCompletedTask();
                        if (!isCompleted)
                        {
                            await Task.Delay(TimeSpan.FromSeconds(seconds), token);
                        }
                        
                    }
                    return isCompleted;
                }, token);
        }
    }
}
