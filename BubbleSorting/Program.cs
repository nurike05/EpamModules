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

            Context sort = new Context();

            sort.SetStrategy(new AlgorithmSortedBySum());           // Sorted by row sum
            var sortedBySum = sort.Sort(jaggedArray1);
            Console.WriteLine("The result of sorted by row sum: ");
            ShowingConsole.ShowConsole(sortedBySum);
      
            sort.SetStrategy(new AlgorithmSortedByRowMin());        // Sorted by row min
            var sortedByRowMin = sort.Sort(jaggedArray1);
            Console.WriteLine("The result of sorted by row min: ");
            ShowingConsole.ShowConsole(sortedByRowMin);
    
            sort.SetStrategy(new AlgorithmSortedByRowMax());        // Sorted by row max
            var sortedByRowMax = sort.Sort(jaggedArray1);
            Console.WriteLine("The result of sorted by row max: ");
            ShowingConsole.ShowConsole(sortedByRowMax);

            Console.ReadLine();
        }
    }
}
