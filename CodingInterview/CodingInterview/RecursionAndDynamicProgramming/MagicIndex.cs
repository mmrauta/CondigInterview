using System;
using System.Linq;

namespace CodingInterview.RecursionAndDynamicProgramming
{
    /// <summary>
    /// A magic index in an array A[1...n-1] is defined to be an index such that A[i] = i.
    /// Given a sorted array of distinct integers, write a method to find a magic index, if one exists, in array A.
    /// </summary>
    public static class MagicIndex
    {
        public static int? Run(int[] array)
        {
            if (array == null || !array.Any())
                return null;

            return Search(array, 0, array.Length - 1);
        }

        private static int? Search(int[] array, int x, int y)
        {
            if (x > y)
                return null;

            var i = (x + y) / 2;

            if (array[i] > i)
                return Search(array, x, i - 1);

            if (array[i] < i)
                return Search(array, i + 1, y);

            return i;
        }

        public static int? RunWithDuplicates(int[] array)
        {
            if (array == null || !array.Any())
                return null;

            return SearchWithDuplicates(array, 0, array.Length - 1);
        }

        private static int? SearchWithDuplicates(int[] array, int start, int end)
        {
            if (start > end)
                return null;

            var i = (start + end) / 2;
            if (array[i] == i)
                return i;

            var leftIndex = Math.Min(i - 1, array[i]);
            var rightIndex = Math.Max(i + 1, array[i]);

            return SearchWithDuplicates(array, start, leftIndex) ?? SearchWithDuplicates(array, rightIndex, end);
        }
    }
}
