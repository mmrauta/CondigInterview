using System.Collections.Generic;
using System.Linq;

namespace CodingInterview.RecursionAndDynamicProgramming
{
    /// <summary>
    /// Write a method to compute all permutations of a string whose characters are not necessarily unique.
    /// The list of permutations should not have duplicates.
    /// </summary>
    public static class PermutationWithDuplicates
    {
        public static List<string> Run(string input)
        {
            if (string.IsNullOrEmpty(input))
                return new List<string>();

            var letters = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (letters.ContainsKey(letter))
                    letters[letter]++;
                else
                    letters[letter] = 1;
            }

            return GetPermutations("", letters);
        }

        private static List<string> GetPermutations(string text, Dictionary<char, int> lettersLeft)
        {
            if (lettersLeft.Values.Sum() == 0)
                return new List<string> { text };

            var results = new List<string>();
            foreach (var letter in lettersLeft.Keys.ToList())
                if (lettersLeft[letter] > 0)
                {
                    lettersLeft[letter]--;
                    var permutations = GetPermutations(text + letter, lettersLeft);
                    results.AddRange(permutations);
                    lettersLeft[letter]++;
                }

            return results;
        }
    }
}
