using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynom
{
    class Polynom
    {
        int[] Matrix;
        int Degree;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="matrix">The length of the polynom.</param>
        /// <param name="degree">The degree of the polynom.</param>
        public Polynom(int[] matrix, int degree)
        {
            Matrix = matrix;
            Degree = degree;
        }

        /// <summary>
        /// Method of the overloaded addition operator
        /// </summary>
        /// <param name="A">The first polynom.</param>
        /// <param name="B">The second polynom.</param>
        /// <returns>Sum of two polynoms.</returns>
        public static Polynom operator +(Polynom A, Polynom B)
        {
            int D1 = A.Degree;
            int[] M1 = new int[D1 + 1];
            Polynom C = new Polynom(M1, D1);

            for (int i = 0; i <= A.Degree; i++)
            {
                C.Matrix[i] = A.Matrix[i] + B.Matrix[i];
            }
            return C;
        }

        /// <summary>
        /// Method of the overloaded subtraction operator 
        /// </summary>
        /// <param name="A">The first polynom.</param>
        /// <param name="B">The second polynom.</param>
        /// <returns>Difference of two polynoms.</returns>
        public static Polynom operator -(Polynom A, Polynom B)
        {
            int D1 = A.Degree;
            int[] M1 = new int[D1 + 1];
            Polynom C = new Polynom(M1, D1);

            for (int i = 0; i <= A.Degree; i++)
            {
                C.Matrix[i] = A.Matrix[i] - B.Matrix[i];
            }
            return C;
        }

        /// <summary>
        /// Method of the overloaded derivative operator
        /// </summary>
        /// <param name="A">The first polynom.</param>
        /// <param name="B">The second polynom.</param>
        /// <returns>Derivative of two polynoms.</returns>
        public static Polynom operator *(Polynom A, Polynom B)
        {
            int D1 = A.Degree + B.Degree;
            int[] M1 = new int[D1 + 1];
            Polynom C = new Polynom(M1, D1);

            for (int i = 0; i <= A.Degree; i++)
            {
                for (int j = 0; j <= B.Degree; j++)
                {
                    C.Matrix[i + j] += A.Matrix[i] * B.Matrix[j];
                }
            }
            return C;
        }

        public override bool Equals(Object o)
        {
            if (o == null)
                return false;

            Type typ = this.GetType();
            if (!typ.Equals(o.GetType()))
                return false;

            Polynom p = (Polynom)o;
            if (this.Degree != p.Degree)
                return false;

            for (int i = 0; i < this.Matrix.Length; i++)
                if (this.Matrix[i] != p.Matrix[i])
                    return false;

            return true;
        }
        public override int GetHashCode()
        {
            return this.Matrix.GetHashCode();
        }

        // comparison operators
        public static bool operator ==(Polynom p1, Polynom p2)
        {
            return p1 == p2;
        }

        public static bool operator !=(Polynom p1, Polynom p2)
        {
            return !(p1 == p2);
        }

        public int Display(Polynom A)             // Display on the console
        {
            for (int i = 0; i < Matrix.Length; i++)
            {
                if (Matrix[i] == 0)
                {
                    continue;
                }
                else if (Degree == 0)
                {
                    continue;
                }
                else if (Degree == 1)
                {
                    Console.Write(Matrix[i]);
                    break;
                }
                else if (Matrix[i] >= 1 || Degree >= 2)
                {
                    Console.Write(Matrix[i] + "X" + "^" + (Degree - i) + "+");
                }
            }
            return 0;
        }
    }
}
