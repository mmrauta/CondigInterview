using System.Collections.Generic;

namespace CodingInterview.RecursionAndDynamicProgramming
{
    public static class Parenthesis
    {
        public static List<string> Run(int n)
        {
            if (n < 1)
                return new List<string>();

            return Get(n, n, "");
        }

        private static List<string> Get(int left, int right, string currentPermutation)
        {
            if (left == 0 && right == 0)
                return new List<string> { currentPermutation };

            var results = new List<string>();

            if (left > 0)
            {
                var resultLeft = Get(left - 1, right, currentPermutation + "(");
                results.AddRange(resultLeft);
            }

            if (right > 0 && left < right)  // left must be smaller than right to have valid parenthesis sets
            {
                var resultRight = Get(left, right -1, currentPermutation + ")");
                results.AddRange(resultRight);
            }

            return results;
        }
    }
}
