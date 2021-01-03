using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConverter
{
    public static class MainConverter
    {
        /// <summary>
        /// Method DoubleHelper to convert from Double to Binary string
        /// </summary>
        /// <param name="doubleNumber">Input number in 'double' type</param>
        /// <returns>string data</returns>
        public static string DoubleHelper(double number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Byte[] doubleByte = BitConverter.GetBytes(number);
            foreach(Byte b in doubleByte)
            {
                for (int i = 0; i <= 7; i++)
                {
                    stringBuilder.Insert(0, ((b >> i) & 1) == 1 ? "1" : "0");
                }
            }
            string doubleToString = stringBuilder.ToString();
            return doubleToString;
        }
    }
}
