using System.Linq;

namespace CodingInterview.ArraysAndStrings
{
    /// <summary>
    /// Write a method to replace all spaces in a string with '%20'.
    /// You may assume that the string has sufficient space at the end to hold additional characters, and that you're given the 'true' length of a string.
    /// </summary>
    public static class URLify
    {
        public const string Space = "%20";

        public static string Run(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            var words = input.Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToList();
            return string.Join(Space, words);
        }

        public static string RunWithLength(char[] input, int length)
        {
            if (input == null || !input.Any())
                return string.Empty;

            var spacesCount = 0;
            for (var i = 0; i < length; i++)
            {
                if (input[i] == ' ')
                    spacesCount++;
            }

            var index = length + spacesCount * 2;
            for (var i = length - 1; i >= 0 ; i--)
            {
                if (input[i] == ' ')
                {
                    input[--index] = '0';
                    input[--index] = '2';
                    input[--index] = '%';
                }
                else
                {
                    input[--index] = input[i];
                }

            }

            return string.Join("", input).Trim();
        }
    }
}
