using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3._1
{
    public class NewtonSqrtN
    {
        /// <summary>
        /// Сlass that checks input data for the mistakes.
        /// </summary>
        /// <param name="number">Number, that root is needed to find.</param>
        /// <param name="degree">Root degree.</param>
        /// <param name="precision">Precision of the number.</param>
        /// <exception cref="ArgumentException">ArgumentException.</exception>
        /// <returns>Nth root of the number.</returns>
        public static double FindRoot(double number, int degree, double precision)
        {
            if (precision <= 0 || precision >= 1)
            {
                throw new ArgumentException("It has to contain a number in range: (0, 1).");
            }

            if (degree % 2 == 0 && number < 0)
            {
                throw new ArgumentException("It is impossible to calculate. Nth root is negative value and N is even.");
            }

            if (degree <= 0)
            {
                throw new ArgumentException("It has to be positive.");
            }

            if (degree == 1)
            {
                return number;
            }

            return FindNthRoot(number, degree, precision);
        }

        /// <summary>
        /// Method FindNthRoot().
        /// </summary>
        /// <param name="number">Number of the root.</param>
        /// <param name="degree">Root degree.</param>
        /// <param name="precision">Precision.</param>
        /// <returns>Nth root of the number.</returns>
        private static double FindNthRoot(double number, int degree, double precision)
        {
            double number1 = 1;
            double next = SetIterationNumber(number1, degree, number);

            while (Math.Abs(number1 - next) >= precision)
            {
                number1 = next;
                next = SetIterationNumber(number1, degree, number);
            }

            return next;
        }

        /// <summary>
        /// Method that set iteration number.
        /// </summary>
        /// <param name="current">Current value of needed root value.</param>
        /// <param name="degree">Root degree.</param>
        /// <param name="number">Needed root value.</param>
        /// <returns>New value for the Newton algorithm.</returns>
        private static double SetIterationNumber(double current, int degree, double number)
        {
            var result = (((degree - 1) * current) + (number / Math.Pow(current, degree - 1))) / degree;
            return result;
        }
    }
}
