using System;

namespace EuclideanAlg
{
    public interface ISteinMethod
    {
        int SteinMethod(params int[] numbers);
        int SteinMethod(out double time, params int[] numbers);
    }
}
