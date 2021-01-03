﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    public class Context
    {
        private ISortingAlgorithm strategy;

        internal void SetStrategy(ISortingAlgorithm strategy)
        {
            this.strategy = strategy;
        }

        public int[][] Sort(int[][] arr)
        {
            var result = strategy.SortJaggedArray(arr);
            return result;
        }
    }
}