using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynom
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////// The first polynom
            Console.WriteLine("The form of the entering polynoms: ");
            Console.WriteLine("\t a*X^n + b*X^(n-1) + ... + z*X^0");
            Console.WriteLine("Enter the degree of the first polynom \"n\":");

            int Degree = 0;
            int n = 0;
            for (int i = 0; i < 1; i++)                                 // Checking the entered data
            {
                try
                {
                    Degree = Convert.ToInt32(Console.ReadLine());
                    n = Degree + 1;                                     //The length of the polynom
                }
                catch (Exception)
                {
                    Console.WriteLine("Please, enter an integer number!!!");
                    i--;
                }
            }

            int[] Matrix = new int[n];
            Console.WriteLine("Enter coefficients of the polynom \"a\", \"b\", \"z\", etc:");
            for (int i = 0; i <= Degree; i++)                           // Checking the entered data
            {
                try
                {
                    Matrix[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please, enter an integer number!!!");
                    i--;
                }
            }

            /////////// The second polynom
            Console.WriteLine("Enter the degree of the second polynom \"n\":");
            int Degree2 = 0;
            int n2 = 0;
            for (int i = 0; i < 1; i++)                                 // Checking the entered data
            {
                try
                {
                    Degree2 = Convert.ToInt32(Console.ReadLine());
                    n2 = Degree2 + 1;                                   //The length of the polynom
                }
                catch (Exception)
                {
                    Console.WriteLine("Please, enter an integer number!!!");
                    i--;
                }
            }


            int[] Matrix2 = new int[n2];
            Console.WriteLine("Enter coefficients of the second polynom \"a\", \"b\", \"z\", etc:");

            for (int i = 0; i <= Degree2; i++)                          // Checking the entered data
            {
                try
                {
                    Matrix2[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please, enter an integer number!!!");
                    i--;
                }
            }




            if (Degree < Degree2)                       // If the length of the first polynom is less than the second polynom
            {
                int difference = Degree2 - Degree;
                Array.Resize(ref Matrix, Matrix.Length + difference);

                for (int j = 0; j < difference; j++)
                {
                    int temp = Matrix[0];               
                    Matrix[0] = Matrix[Matrix.Length - 1]; 

                    // swap the last element to the first
                    for (int index = 1; index < Matrix.Length; index++)
                    {
                        int next = Matrix[index];      
                        Matrix[index] = temp;           
                        temp = next;                   
                    }
                }
            }
            else
            {
                int difference = Degree - Degree2;
                Array.Resize(ref Matrix2, Matrix2.Length + difference);

                for (int j = 0; j < difference; j++)
                {
                    int temp = Matrix2[0];          
                    Matrix2[0] = Matrix2[Matrix.Length - 1]; 

                    // swap the last element to the first
                    for (int index = 1; index < Matrix2.Length; index++)
                    {
                        int next = Matrix2[index];     
                        Matrix2[index] = temp;          
                        temp = next;                  
                    }
                }
            }


            // Display on the console

            if (Degree < Degree2)                       // If the length of the first polynom is less than the second polynom
            {
                Polynom A = new Polynom(Matrix, Degree2);
                Polynom B = new Polynom(Matrix2, Degree2);
                Polynom C = A + B;                          // Addition
                Polynom F = A - B;                          // Subtraction
                Polynom J = A * B;                          // Multiplication
                Console.Write("A=");
                Console.WriteLine(A.Display(A));              // Display the first polynom
                Console.Write("B=");
                Console.WriteLine(B.Display(B));              // Display the second polynom
                Console.Write("A+B=");
                Console.WriteLine(C.Display(C) + "\n");       // Display the sum of two polynoms
                Console.Write("A-B=");
                Console.WriteLine(F.Display(F) + "\n");       // Display the subtraction of two polynoms
                Console.Write("A*B=");
                Console.WriteLine(J.Display(J) + "\n");       // Display the derivative of two polynoms
            }
            else                                        // If the length of the first polynom is greater than (or equal to the second) polynom
            {
                Polynom A = new Polynom(Matrix, Degree);   
                Polynom B = new Polynom(Matrix2, Degree);  
                Polynom C = A + B;                          // Addition
                Polynom F = A - B;                          // Subtraction
                Polynom J = A * B;                          // Multiplication
                Console.Write("A=");
                Console.WriteLine(A.Display(A));              // Display the first polynom
                Console.Write("B=");
                Console.WriteLine(B.Display(B));              // Display the second polynom
                Console.Write("A+B=");
                Console.WriteLine(C.Display(C) + "\n");       // Display the sum of two polynoms
                Console.Write("A-B=");
                Console.WriteLine(F.Display(F) + "\n");       // Display the subtraction of two polynoms
                Console.Write("A*B=");
                Console.WriteLine(J.Display(J) + "\n");       // Display the derivative of two polynoms
            }
            Console.ReadLine();
        }
    }
}
