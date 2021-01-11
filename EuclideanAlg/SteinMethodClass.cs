using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanAlg
{
    public class SteinMethodClass : ISteinMethod
    {
        Timer timer = new Timer();

        /// <summary>
        /// The SteinMethod (Stein algorithm (Euclid's binary algorithm)) method 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>GCD of integer array</returns>
        public int SteinMethod(params int[] numbers)
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

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i + 1] = SteinGcd(numbers[i], numbers[i + 1]);
            }
            return numbers[numbers.Length - 1];
        }

        public int SteinMethod(out double time, params int[] numbers)
        {
            return timer.CalculateTime(() => SteinMethod(numbers), out time);
        }

        private int SteinGcd(int firstNumber, int secondNumber)
        {
            int shift;
            for (shift = 0; ((firstNumber | secondNumber) & 1) == 0; ++shift)
            {
                firstNumber >>= 1;
                secondNumber >>= 1;
            }
            while ((firstNumber & 1) == 0)
                firstNumber >>= 1;
            do
            {
                while ((secondNumber & 1) == 0)
                    secondNumber >>= 1;
                if (firstNumber > secondNumber)
                {
                    int t = secondNumber;
                    secondNumber = firstNumber;
                    firstNumber = t;
                }
                secondNumber = secondNumber - firstNumber;
            } while (secondNumber != 0);
            return firstNumber << shift;
        }
    }
}
