using System.Collections.Generic;
using System.Linq;

namespace CodingInterview.ArraysAndStrings
{
    /// <summary>
    /// Implement an algorithm to determine if a string has all unique characters.
    /// What if you cannot use additional data structures?
    /// </summary>
    public static class IsUnique
    {
        /// <summary>
        /// I'm assuming we are using ASCII characters. There is 128 ASCII characters,
        /// so max length of a string with unique characters is 128.
        /// </summary>
        public static bool Run(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;

            if (input.Length > 128)
                return false;

            var set = new HashSet<char>();

            for (var i = 0; i < input.Length; i++)
            {
                if (set.Contains(input[i]))
                    return false;

                set.Add(input[i]);
            }

            return true;
        }

        /// <summary>
        /// This solution changes the input string, but is faster then comparing each character with the rest of the string O(n^2).
        /// Time complexity thanks to sorting - O(n*log(n))
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool RunInPlace(List<char> input)
        {
            if (input == null || !input.Any())
                return true;

            if (input.Count > 128)
                return false;

            input.Sort();
            
            var previous = input[0];

            for (var i = 1; i < input.Count; i++)
            {
                if (input[i] == previous)
                    return false;

                previous = input[i];
            }

            return true;
        }
    }
}
