using NUnit.Framework;

namespace BubbleSorting
{
    class BubbleSortingTests
    {
        [Test]
        public void Sorted_By_Row_Sum()
        {
            Context sorting = new Context();
            sorting.SetStrategy(new AlgorithmSortedBySum());

            int[][] array = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 0, 1, 2, 3 },
                new int[] { 6, 7, 8},
                new int[] { 33, 44 }
            };

            int[][] arrayExpected = new int[][]
            {
                new int[] { 33, 44 },
                new int[] { 6, 7, 8},
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 0, 1, 2, 3 }
            };


            var result = sorting.Sort(array);

            Assert.AreEqual(arrayExpected, result);
            int[][] array2 = new int[][]
            {
                new int[] { 0, 0, 9 },
                new int[] { 10, 12 },
                new int[] { 1, 2, 3},
                new int[] { 77, 7 }
            };
            int[][] arrayExpected2 = new int[][]
            {
                new int[] { 77, 7 },
                new int[] { 10, 12 },
                new int[] { 0, 0, 9 },
                new int[] { 1, 2 , 3}
            };
            Assert.AreEqual(sorting.Sort(array2), arrayExpected2);
        }

        [Test]
        public void Sorted_By_Row_Max()
        {
            Context sorting = new Context();
            sorting.SetStrategy(new AlgorithmSortedByRowMax());

            int[][] array = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 0, 1, 2, 3 },
                new int[] { 6, 7, 8},
                new int[] { 33, 44 }
            };

            int[][] arrayExpected = new int[][]
            {
                new int[] { 33, 44 },
                new int[] { 6, 7, 8},
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 0, 1, 2, 3 }
            };


            var result = sorting.Sort(array);

            Assert.AreEqual(arrayExpected, result);
            int[][] array2 = new int[][]
            {
                new int[] { 0, 0, 9 },
                new int[] { 10, 12 },
                new int[] { 1, 2, 3},
                new int[] { 77, 7 }
            };
            int[][] arrayExpected2 = new int[][]
            {
                new int[] { 77, 7 },
                new int[] { 10, 12 },
                new int[] { 0, 0, 9 },
                new int[] { 1, 2 , 3}
            };
            Assert.AreEqual(sorting.Sort(array2), arrayExpected2);
        }

        [Test]
        public void Sorted_By_Row_Min()
        {
            Context sorting = new Context();
            sorting.SetStrategy(new AlgorithmSortedByRowMin());

            int[][] array = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 0, 1, 2, 3 },
                new int[] { 6, 7, 8},
                new int[] { 33, 44 }
            };

            int[][] arrayExpected = new int[][]
            {
                new int[] { 0, 1, 2, 3 },
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 6, 7, 8},
                new int[] { 33, 44 }
            };


            var result = sorting.Sort(array);

            Assert.AreEqual(arrayExpected, result);
            int[][] array2 = new int[][]
            {
                new int[] { 0, 0, 9 },
                new int[] { 10, 12 },
                new int[] { 1, 2, 3},
                new int[] { 77, 7 }
            };
            int[][] arrayExpected2 = new int[][]
            {
                new int[] { 0, 0, 9 },
                new int[] { 1, 2 , 3},
                new int[] { 77, 7 },
                new int[] { 10, 12 }
            };
            Assert.AreEqual(sorting.Sort(array2), arrayExpected2);
        }
    }
}
