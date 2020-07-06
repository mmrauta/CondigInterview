using CodingInterview.ArraysAndStrings;
using System.Linq;
using Xunit;

namespace CodingInterviewTests
{
    public class ArraysAndStringsTests
    {
        [Theory]
        [InlineData("", true)]
        [InlineData("abcdefghijklmnopqrstuvwxyz", true)]
        [InlineData("marta", false)]
        public void IsUniqueTest(string input, bool expectedResult)
        {
            var result = IsUnique.Run(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("", true)]
        [InlineData("abcdefghijklmnopqrstuvwxyz", true)]
        [InlineData("marta", false)]
        public void IsUniqueInPlaceTest(string input, bool expectedResult)
        {
            var inputFormatted = input.ToCharArray().ToList();
            var result = IsUnique.RunInPlace(inputFormatted);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("", "", true)]
        [InlineData("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz", true)]
        [InlineData("marta", "darta", false)]
        [InlineData("marta", "marta", true)]
        [InlineData("m a r t a", "mart a", false)]
        public void CheckPermutationTest(string inputOne, string inputTwo, bool expectedResult)
        {
            var result = CheckPermutation.Run(inputOne, inputTwo);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("", "", true)]
        [InlineData("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz", true)]
        [InlineData("marta", "darta", false)]
        public void CheckPermutationWithoutSortTest(string inputOne, string inputTwo, bool expectedResult)
        {
            var result = CheckPermutation.RunWithoutSort(inputOne, inputTwo);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz")]
        [InlineData("marta", "marta")]
        [InlineData("Mr John Smith   ", "Mr%20John%20Smith")]
        [InlineData("a b c     ", "a%20b%20c")]
        public void URLifyTest(string input, string expectedResult)
        {
            var result = URLify.Run(input);
            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData("", 0, "")]
        [InlineData("abcdefghijklmnopqrstuvwxyz", 26, "abcdefghijklmnopqrstuvwxyz")]
        [InlineData("marta", 5, "marta")]
        [InlineData("Mr John Smith         ", 13, "Mr%20John%20Smith")]
        [InlineData("a b     ", 3, "a%20b")]
        public void URLifyWithCountTest(string input, int length, string expectedResult)
        {
            var result = URLify.RunWithLength(input.ToCharArray(), length);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("", true)]
        [InlineData("abcdefghijklmnopqrstuvwxyz", false)]
        [InlineData("marta", false)]
        [InlineData("aabbccdde", true)]
        public void PalindromePermutationTest(string input, bool expectedResult)
        {
            var result = PalindromePermutation.Run(input);
            Assert.Equal(expectedResult, result);
        }
    }
}
