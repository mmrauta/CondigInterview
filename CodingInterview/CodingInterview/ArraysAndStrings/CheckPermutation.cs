using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace CodingInterview.ArraysAndStrings
{
    /// <summary>
    /// Given two strings, write a method to decide if one is a permutation of the other.
    /// </summary>
    public static class CheckPermutation
    {
        public static bool Run(string one, string two)
        {
            if (one.Length != two.Length)
                return false;

            var oneSorted = one.OrderBy(x => x).ToList();
            var twoSorted = two.OrderBy(x => x).ToList();

            var first = string.Join("", oneSorted);
            var second = string.Join("", twoSorted);

            return first.Equals(second);
        }

        public static bool RunWithoutSort(string one, string two)
        {
            if (one.Length != two.Length)
                return false;

            var letters = new Dictionary<char, int>();

            foreach (var character in one)
            {
                if (letters.ContainsKey(character))
                    letters[character]++;
                else
                    letters.Add(character, 1);
            }

            foreach (var character in two)
            {
                if (letters.ContainsKey(character))
                    letters[character]--;
                else
                    return false;

                if (letters[character] < 0)
                    return false;
            }
            
            return letters.Values.All(x => x == 0);
        }
    }
}
