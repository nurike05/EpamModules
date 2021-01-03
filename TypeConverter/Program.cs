using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConverter
{
    public class Program
    {   
        /// <summary>
        /// Method for checking one of the sample in DoubleHelper method
        /// </summary>
        public static void Main()
        {
            double sample = -255.255;
            string result = MainConverter.DoubleHelper(sample);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
