using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanAlg
{
    public class Timer : ITimer
    {
        public int CalculateTime(Func<int> calculateGcd, out double time)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int result = calculateGcd();

            stopwatch.Stop();
            time = stopwatch.Elapsed.TotalMilliseconds;

            return result;
        }
    }
}
