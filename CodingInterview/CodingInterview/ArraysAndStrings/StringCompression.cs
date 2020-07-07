using System.Text;

namespace CodingInterview.ArraysAndStrings
{
    /// <summary>
    /// Implement a method to perform basic string compression using the counts of repeated characters.
    /// For example, the string 'aabcccccaaa' would become 'a2b1c5a3'.
    /// If the compressed string would not become smaller than the original string, your method should return the original string.
    /// </summary>
    public static class StringCompression
    {
        public static string Run(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            var output = new StringBuilder();

            var i = 0;
            while (i < input.Length)
            {
                var counter = 0;
                for (var j = i; j < input.Length && input[i] == input[j]; j++)
                    counter++;

                output.Append(input[i]).Append(counter);
                i += counter;
            }

            var result = output.ToString();

            return result.Length < input.Length ? result : input;
        }
    }
}
