using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    interface ISortingAlgorithm
    {
        int SortArray(int[] array);
        int[][] SortJaggedArray(int[][] jaggedArray);
        int[][] SwapRows(int[][] arr, int i1, int i2);
    }
}
