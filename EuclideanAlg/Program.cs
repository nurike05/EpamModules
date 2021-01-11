using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanAlg
{
    class Program
    {
        public delegate int CalculateEuclidean(params int[] number);
        public delegate int CalculateEuclideanTime(out double time, params int[] number);
        static void Main(string[] args)
        {
            CalculateEuclidean calculateEuclidean;
            CalculateEuclideanTime euclideanTime;

            EuclideanMethodClass euclideanMethod = new EuclideanMethodClass();
            calculateEuclidean = euclideanMethod.EuclideanMethod;
            var result = calculateEuclidean(982, 2);
            Console.WriteLine($"The GCD Euclidean Method is {result}");

            SteinMethodClass steinMethod = new SteinMethodClass();
            calculateEuclidean = steinMethod.SteinMethod;
            var resultStein = calculateEuclidean(171, 9);
            Console.WriteLine($"The GCD Stein Method is {resultStein}");

            euclideanTime = euclideanMethod.EuclideanMethod;
            euclideanTime(out double time, 982, 2);
            Console.WriteLine($"The time of GCD Euclidean Method is {time}");

            euclideanTime = steinMethod.SteinMethod;
            euclideanTime(out double timeStein, 982, 2);
            Console.WriteLine($"The time of GCD Stein Method is {timeStein}");
            Console.ReadLine();
        }
    }
}
