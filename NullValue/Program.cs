using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data;

namespace NullValue
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = ""; 
            str.IsNull();

            int? i = 9;
            i.IsNull();

            string anyWord = "Word";
            anyWord.IsNull();
          
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Extension for any value to IsNull()
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Method for checking strings whether they are null or not
        /// </summary>
        /// <param name="str">Any input strings</param>
        /// <returns>Boolean value</returns>
        public static bool IsNull(this string str)
        {
            if (str == null || str == "")
            {
                Console.WriteLine("true");
                return true;
            }
            else
            {
                Console.WriteLine("false");
                return false;
            }
        }

        /// <summary>
        /// Method for checking numbers whether they are null or not
        /// </summary>
        /// <param name="number">Any input numbers</param>
        /// <returns>Boolean value</returns>
        public static bool IsNull(this int? number)
        {
            if (number == null || number == 0)
            {
                Console.WriteLine("true");
                return true;
            }
            else
            {
                Console.WriteLine("false");
                return false;
            }
        }
    }  
}
