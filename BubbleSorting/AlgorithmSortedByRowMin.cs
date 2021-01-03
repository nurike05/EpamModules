using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    public class AlgorithmSortedByRowMin : ISortingAlgorithm
    {
        /// <summary>
        /// Minimum number of row element of array
        /// </summary>
        /// <param name="array">An array from SortByRowMin(int[][] array)</param>
        /// <returns>Minimum number of row element of array</returns>
        public int SortArray(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Sort by a minimum element number in increasing order
        /// </summary>
        /// <param name="jaggedArray">Jagged array</param>
        /// <returns>Sort by a minimum element number in increasing order</returns>
        public int[][] SortJaggedArray(int[][] jaggedArray)
        {
            for (int j = 1; j < jaggedArray.Length; j++)
            {
                for (int i = 1; i < jaggedArray.Length; i++)
                {
                    if (this.SortArray(jaggedArray[i]) < this.SortArray(jaggedArray[i - 1]))
                    {
                        this.SwapRows(jaggedArray, i, i - 1);
                    }
                }
            }
            return jaggedArray;
        }

        /// <summary>
        /// Swap rows from sorting methods of jagged arrays (int[][] arr)
        /// </summary>
        /// <param name="arr">Jagged arrays (int[][] arr)</param>
        /// <param name="i1">Previous row of array</param>
        /// <param name="i2">Next row of array</param>
        /// <returns>Swapped 2 rows of array</returns>
        public int[][] SwapRows(int[][] arr, int i1, int i2)
        {
            var temp = arr[i2];
            arr[i2] = arr[i1];
            arr[i1] = temp;
            return arr;
        }
    }
}
