using System;

namespace EuclideanAlg
{
    public interface ITimer
    {
        int CalculateTime(Func<int> calculateGcd, out double time);
    }
}
