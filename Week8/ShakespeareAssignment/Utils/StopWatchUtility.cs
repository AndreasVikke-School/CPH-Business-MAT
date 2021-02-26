using System;
using System.Diagnostics;

namespace ShakespeareAssignment.Utils
{
    public class StopWatchUtility
    {
        public static readonly Stopwatch stopWatch = new Stopwatch();

        public static T time<T>(Func<T> methodToTime) {
            stopWatch.Start();
            T result = methodToTime();
            stopWatch.Stop();
            Console.WriteLine($"Time elapsed: {stopWatch.Elapsed}");
            stopWatch.Reset();
            return result;
        }
    }
}