using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanAlg
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = EuclideanGCD.EuclideanMethod(982, 2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
