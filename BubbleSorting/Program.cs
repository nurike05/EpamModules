using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{

    class Program
    {
        static void Main(string[] args)
        {
            
            int[][] jaggedArray1 = new int[][]      // An example of jagged array
            {
                new int[] { 1, 2, 3, 4, 5, 6 },
                new int[] { 10, 20, 30 },
                new int[] { 3, 5, 100},
                new int[] { 77, 88, 99 },
                new int[] { 0, 0 }
            };

            SortingAlgorithm sort = new SortingAlgorithm();

            var sortedBySum = sort.SortByRowSum(jaggedArray1);          // Sorted by row sum
            Console.WriteLine("The result of sorted by row sum: ");
            ShowingConsole.ShowConsole(sortedBySum);

            var sortedByRowMin = sort.SortByRowMin(jaggedArray1);       // Sorted by row min
            Console.WriteLine("The result of sorted by row min: ");
            ShowingConsole.ShowConsole(sortedByRowMin);

            Console.WriteLine("The result of sorted by row max: ");     // Sorted by row max
            var sortedByRowMax = sort.SortByRowMax(jaggedArray1);
            ShowingConsole.ShowConsole(sortedByRowMax);

            Console.WriteLine("The swapped result of sorted by row max: "); // The swapped result of sorted by row max
            var swapped = sort.SwapRows(sortedByRowMax, 2, 3);
            ShowingConsole.ShowConsole(swapped);

            Console.ReadLine();
        }
    }
}
