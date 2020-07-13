using System.Collections.Generic;

namespace CodingInterview.RecursionAndDynamicProgramming
{
    /// <summary>
    /// Write a method to compute all permutations of a string of unique characters.
    /// </summary>
    public static class PermutationNoDuplicates
    {
        public static List<string> RunRecursive(string input)
        {
            if (string.IsNullOrEmpty(input))
                return new List<string>();

            var memo = new Dictionary<int, List<string>>();
            memo[0] = new List<string> { input[0].ToString() };
            return GetPermutations(input, input.Length - 1, memo);
        }

        private static List<string> GetPermutations(string input, int index, Dictionary<int, List<string>> memo)
        {
            if (memo.ContainsKey(index))
                return memo[index];

            var previousRound = GetPermutations(input, index - 1, memo);
            var newPermutations = new List<string>();

            foreach (var set in previousRound)
                for (var i = 0; i <= set.Length; i++)
                {
                    var permutation = GetNewPermutation(set, input[index], i);
                    newPermutations.Add(permutation);
                }

            memo[index] = newPermutations;
            return memo[index];
        }

        public static List<string> RunIterative(string input)
        {
            if (string.IsNullOrEmpty(input))
                return new List<string>();

            var memo = new Dictionary<int, List<string>>();
            memo[0] = new List<string> { input[0].ToString() };

            for (var index = 1; index < input.Length; index++)
            {
                var previousRound = memo[index - 1];
                var newPermutations = new List<string>();
                foreach (var set in previousRound)
                    for (var i = 0; i <= set.Length; i++)
                    {
                        var permutation = GetNewPermutation(set, input[index], i);
                        newPermutations.Add(permutation);
                    }

                memo[index] = newPermutations;
            }

            return memo[input.Length - 1];
        }

        private static string GetNewPermutation(string previousPermutation, char newLetter, int splitIndex) 
            => previousPermutation.Substring(0, splitIndex)
               + newLetter
               + previousPermutation.Substring(splitIndex);
    }
}
