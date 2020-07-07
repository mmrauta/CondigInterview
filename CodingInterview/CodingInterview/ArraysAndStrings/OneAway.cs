using System;

namespace CodingInterview.ArraysAndStrings
{
    /// <summary>
    /// There are three types of edits that can be performed on strings: insert a character, remove a character or replace a character.
    /// Given two strings, write a function to check if they are one edit (or zero edits) away.
    /// example: pale -> ple true, pales -> pale true, pale -> bale true, pale -> bake false
    /// </summary>
    public static class OneAway
    {
        public static bool Run(string one, string two)
        {
            if (Math.Abs(one.Length - two.Length) > 1)
                return false;

            var (longer, shorter) = GetByLengths(one, two);

            var foundChange = false;
            for (int i = 0, j = 0; i < longer.Length && j < shorter.Length; i++, j++)
            {
                if (longer[i] == shorter[j] || (foundChange && i+1 < longer.Length && longer[i+1] == shorter[j] ))
                    continue;

                if (foundChange)
                    return false;

                foundChange = true;
            }

            return true;
        }

        private static (string, string) GetByLengths(string one, string two)
        {
            var longer = one.Length > two.Length ? one : two;
            var shorter= one.Length > two.Length ? two : one;

            return (longer, shorter);
        }
    }
}
