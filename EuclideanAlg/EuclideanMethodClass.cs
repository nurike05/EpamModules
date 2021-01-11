using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanAlg
{
    public class EuclideanMethodClass : IEuclideanMethod
    {
        Timer timer = new Timer();

        /// <summary>
        /// The EuclideanMethod method takes integer array   
        /// /// </summary>
        /// <param name="numbers"></param>
        /// <returns>GCD of integer array numbers(int) and time necessary for calculations(double)</returns>
        public int EuclideanMethod(out double time, params int[] numbers)
        {
            var result = timer.CalculateTime(() => EuclideanMethod(numbers), out time);
            return result;
        }

        public int EuclideanMethod(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException();
            }
            if (numbers == null)
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Math.Abs(numbers[i]);
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[0] = EuclideanGcd(numbers[0], numbers[i]);
            }
            return numbers[0];
        }

        private int EuclideanGcd(int firstNumber, int secondNumber)
        {
            while (firstNumber != secondNumber)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber = firstNumber - secondNumber;
                }
                else
                {
                    secondNumber = secondNumber - firstNumber;
                }
            }
            return firstNumber;
        }
    }
}
