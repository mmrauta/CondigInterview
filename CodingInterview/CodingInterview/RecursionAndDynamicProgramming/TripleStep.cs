using System.Collections.Generic;

namespace CodingInterview.RecursionAndDynamicProgramming
{
    /// <summary>
    /// A child is running up a staircase with n steps and can hop either 1 step, 2 steps or 3 steps at a time.
    /// Implement a method to count how many possible ways the child can run up the stairs.
    /// </summary>
    public static class TripleStep
    {
        public static int RunRecursive(int n)
        {
            var memo = new Dictionary<int, int>();
            return CountWays(n, memo);
        }

        private static int CountWays(int n, Dictionary<int, int> memo)
        {
            if (n < 0)
                return 0;

            if (n == 0)
                return 1;

            if (memo.ContainsKey(n))
                return memo[n];

            memo.Add(n, CountWays(n - 1, memo) + CountWays(n - 2, memo) + CountWays(n - 3, memo));
            return memo[n];
        }

        public static int RunIterative(int n)
        {
            if (n < 0)
                return 0;

            if (n == 0)
                return 1;

            var memo = new Dictionary<int, int> {{ 0, 1 }};
            for (var level = 1; level <= n; level++)
            {
                var total = 0;
                for (var j = 1; j <= 3; j++)
                {
                    var previousStep = level - j;
                    if (previousStep >= 0)
                        total += memo[previousStep];
                }
                memo[level] = total;
            }

            return memo[n];
        }
    }
}
