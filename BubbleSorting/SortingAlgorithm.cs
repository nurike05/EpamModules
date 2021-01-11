using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    public abstract class SortingAlgorithm
    {
        protected abstract int SortArray(int[] array);
        public abstract int[][] SortJaggedArray(int[][] jaggedArray);
        protected abstract int[][] SwapRows(int[][] arr, int i1, int i2);
    }
}
