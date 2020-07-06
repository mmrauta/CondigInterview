using System.Collections.Generic;
using System.Linq;

namespace CodingInterview.ArraysAndStrings
{
    /// <summary>
    /// Given a string, write a function to check if it is a permutation of a palindrome.
    /// A palindrome is a word or phrase that is the same forwards and backwards.
    /// A permutation is a rearrangement of letters. The palindrome does not need to be limited to just dictionary words.
    /// </summary>
    public static class PalindromePermutation
    {
        public static bool Run(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;

            var letters = new Dictionary<char, int>();
            for (var i = 0; i < input.Length; i++)
            {
                if (letters.ContainsKey(input[i]))
                    letters[input[i]] = (letters[input[i]] + 1 ) % 2;
                else
                    letters.Add(input[i], 1);
            }

            var sum = letters.Values.Sum();
            return sum <= 1;
        }
    }
}
