using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    class SortingAlgorithm
    {
        /// <summary>
        /// Sum of element numbers from a row of array
        /// </summary>
        /// <param name="arr">An array from SortByRowSum(int[][] arr)</param>
        /// <returns>Sum of element numbers from a row of array</returns>
        public int SumUpNumbers(int[] arr)  
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        /// <summary>
        /// Maximum number of row element of array
        /// </summary>
        /// <param name="arr">An array from SortByRowMax(int[][] arr)</param>
        /// <returns>Maximum number of row element of array</returns>
        public int TakeRowWithMaxNumber(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Minimum number of row element of array
        /// </summary>
        /// <param name="arr">An array from SortByRowMin(int[][] arr)</param>
        /// <returns>Minimum number of row element of array</returns>
        public int TakeRowWithMinNumber(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            return min;
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

        /// <summary>
        /// Sort by row sum in descending order
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <returns>Sort by row sum in descending order</returns>
        public int[][] SortByRowSum(int[][] arr)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (this.SumUpNumbers(arr[i]) > this.SumUpNumbers(arr[i - 1]))
                    {
                        this.SwapRows(arr, i, i - 1);
                    }
                }
            }

            return arr;
        }

        /// <summary>
        /// Sort by a maxsimum element number in descending order
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <returns>Sort by a maxsimum element number in descending order</returns>
        public int[][] SortByRowMax(int[][] arr)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (this.TakeRowWithMaxNumber(arr[i]) > this.TakeRowWithMaxNumber(arr[i - 1]))
                    {
                        this.SwapRows(arr, i, i - 1);
                    }
                }
            }

            return arr;
        }

        /// <summary>
        /// Sort by a minimum element number in increasing order
        /// </summary>
        /// <param name="arr">Jagged array</param>
        /// <returns>Sort by a minimum element number in increasing order</returns>
        public int[][] SortByRowMin(int[][] arr)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (this.TakeRowWithMinNumber(arr[i]) < this.TakeRowWithMinNumber(arr[i - 1]))
                    {
                        this.SwapRows(arr, i, i - 1);
                    }
                }
            }
            return arr;
        }
    }
}
