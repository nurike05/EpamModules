using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanAlg
{
    public class EuclideanGCD
    {
        /// <summary>
        /// The EuclideanMethod method takes 2 integer parameters
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns> GCD of two numbers(int)</returns>
        public static int EuclideanMethod(int firstNumber, int secondNumber)
        {
            var result = EuclideanGcd(Math.Abs(firstNumber), Math.Abs(secondNumber));
            return result;
        }

        public static int EuclideanMethod(int firstNumber, int secondNumber, out double time)
        {
            var result = CalculateTime(() => EuclideanMethod(firstNumber, secondNumber), out time);
            return result;
        }


        /// <summary>
        /// The EuclideanMethod method takes 3 integer parameters 
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns> GCD of three numbers(int)</returns>
        public static int EuclideanMethod(int firstNumber, int secondNumber, int thirdNumber)
        {
            var result = EuclideanGcd(EuclideanGcd(Math.Abs(firstNumber), Math.Abs(secondNumber)), Math.Abs(thirdNumber));
            return result;
        }

        public static int EuclideanMethod(int firstNumber, int secondNumber, int thirdNumber, out double time)
        {
            var calculatedTime = CalculateTime(() => EuclideanMethod(firstNumber, secondNumber, thirdNumber), out time);
            return calculatedTime;
        }

        /// <summary>
        /// The EuclideanMethod method takes integer array   
        /// /// </summary>
        /// <param name="numbers"></param>
        /// <returns>GCD of integer array numbers(int) and time necessary for calculations(double)</returns>
        public static int EuclideanMethod(out double time, params int[] numbers)
        {
            var result = CalculateTime(() => EuclideanMethod(numbers), out time);
            return result;
        }

        public static int EuclideanMethod(params int[] numbers)
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

        private static int EuclideanGcd(int firstNumber, int secondNumber)
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

        /// <summary>
        /// The SteinMethod (Stein algorithm (Euclid's binary algorithm)) method takes 2 integer values
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>GCD of two numbers(int)</returns>
        public static int SteinMethod(int firstNumber, int secondNumber)
        {
            return SteinGcd(Math.Abs(firstNumber), Math.Abs(secondNumber));
        }
        public static int SteinMethod(int firstNumber, int secondNumber, out double time)
        {
            return CalculateTime(() => SteinMethod(firstNumber, secondNumber), out time); 
        }

        /// <summary>
        ///  The SteinMethod (Stein algorithm (Euclid's binary algorithm)) method takes 3 integer parameters 
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns>GCD of three numbers(int)</returns>
        public static int SteinMethod(int firstNumber, int secondNumber, int thirdNumber)
        {
            return SteinGcd(SteinGcd(firstNumber, secondNumber), thirdNumber);
        }
            
        public static int SteinMethod(int firstNumber, int secondNumber, int thirdNumber, out double time)
        {
            return CalculateTime(() => SteinMethod(firstNumber, secondNumber, thirdNumber), out time);
        }
            
        
        /// <summary>
        /// The SteinMethod (Stein algorithm (Euclid's binary algorithm)) method 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>GCD of integer array</returns>
        public static int SteinMethod(params int[] numbers)
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

        public static int SteinMethod(out double time, params int[] numbers)
        {
            return CalculateTime(() => SteinMethod(numbers), out time);
        }

        private static int SteinGcd(int firstNumber, int secondNumber)
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

        private static int CalculateTime(Func<int> calculateGcd, out double time)
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