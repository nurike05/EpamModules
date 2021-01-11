using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkZ = false;
            do
            {
                long result;
                Console.WriteLine("Please, enter the first number: ");
                bool flag1 = Int64.TryParse(Console.ReadLine(), out long firstNumber);

                Console.WriteLine("Please, enter the second number: ");
                bool flag2 = Int64.TryParse(Console.ReadLine(), out long secondNumber);

                if (!flag1)
                {
                    Console.WriteLine("Please, enter an integer number.");
                }
                else
                {
                    if (!flag2)
                    {
                        Console.WriteLine("Please, enter an integer number.");
                    }
                    else
                    {
                        result = firstNumber + secondNumber;
                        Console.WriteLine(result.ToString());
                    }
                }

                Console.WriteLine("If you would like to stop, press \"0\"");
                bool checkStop = Int32.TryParse(Console.ReadLine(), out int stop);
                if (checkStop)
                {
                    if(stop == 0)
                    {
                        checkZ = true;
                    }
                    else
                    {
                        checkZ = false;
                    }
                }
                else
                {
                    checkZ = false;
                }
            } while (!checkZ);
        }
    }
}
