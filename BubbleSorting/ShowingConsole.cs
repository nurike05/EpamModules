using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    /// <summary>
    /// Class of display on console
    /// </summary>
    class ShowingConsole
    {
        /// <summary>
        /// Display on console
        /// </summary>
        /// <param name="jaggedArray">Jagged array</param>
        public static void ShowConsole(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row number {0}: ", i);

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write("{0}{1}", jaggedArray[i][j], j == (jaggedArray[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
