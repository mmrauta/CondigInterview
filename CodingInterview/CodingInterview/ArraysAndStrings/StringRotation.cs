namespace CodingInterview.ArraysAndStrings
{
    /// <summary>
    /// Assume you have a method isSubstring which checks if one word is substring of another.
    /// Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only one call to isSubstring (e.g. 'watterbottle' is a rotation of 'erbottlewat'
    /// </summary>
    public static class StringRotation
    {
        public static bool Run(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
                return s1 == s2;

            if (s1.Length != s2.Length)
                return false;

            return IsSubstring(s1 + s1, s2);
        }

        private static bool IsSubstring(string s1, string s2) => s1.Contains(s2);
    }
}
