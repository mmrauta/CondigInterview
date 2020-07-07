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

        [Theory]
        [InlineData("", "", true)]
        [InlineData("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz", true)]
        [InlineData("marta", "darta", true)]
        [InlineData("marta", "arta", true)]
        [InlineData("marta", "artax", false)]
        [InlineData("marta", "martax", true)]
        [InlineData("marta", "amrta", false)]
        [InlineData("mmmmm", "mmmm", true)]
        [InlineData("mmmmm", "mmmmm", true)]
        [InlineData("mmmmm", "mmm", false)]
        [InlineData("mmmmm", "mmmmmx", true)]
        public void OneAwayTest(string inputOne, string inputTwo, bool expectedResult)
        {
            var result = OneAway.Run(inputOne, inputTwo);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("aaabbbb", "a3b4")]
        [InlineData("a", "a")]
        [InlineData("abbbbcddd", "a1b4c1d3")]
        [InlineData("aabcccccaaa", "a2b1c5a3")]
        public void CompressesStringTest(string input, string expected)
        {
            var result = StringCompression.Run(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RotateMatrixTest()
        {
            var input = TestHelpers.BuildJaggedGridOne();
            var result = RotateMatrix.Run(input);
            Assert.Equal("781692543", TestHelpers.ToString(result));

            var inputTwo = TestHelpers.BuildJaggedGridTwo();
            var resultTwo = RotateMatrix.Run(inputTwo);
            Assert.Equal("1911282237334654", TestHelpers.ToString(resultTwo));

            var inputThree = TestHelpers.BuildJaggedGridThree();
            var resultThree = RotateMatrix.Run(inputThree);
            Assert.Equal("3142", TestHelpers.ToString(resultThree));
        }

        [Fact]
        public void ZeroMatrixTest()
        {
            var input = TestHelpers.BuildJaggedGridFive();
            var result = ZeroMatrix.Run(input);
            Assert.Equal("1004000090060000", TestHelpers.ToString(result));

            var inputTwo = TestHelpers.BuildJaggedGridSix();
            var resultTwo = ZeroMatrix.Run(inputTwo);
            Assert.Equal("000000000", TestHelpers.ToString(resultTwo));

            var inputThree = TestHelpers.BuildJaggedGridSeven();
            var resultThree = ZeroMatrix.Run(inputThree);
            Assert.Equal("120400009806", TestHelpers.ToString(resultThree));
        }

        [Theory]
        [InlineData("", "", true)]
        [InlineData("abcdefghijklmnopqrstuvwxyz", "lmnopqrstuvwxyzabcdefghijk", true)]
        [InlineData("marta", "rtama", true)]
        [InlineData("marta", "marta", true)]
        [InlineData("marta", "artax", false)]
        [InlineData("marta", "martax", false)]
        [InlineData("waterbottle", "erbottlewat", true)]
        public void StringRotationTest(string inputOne, string inputTwo, bool expectedResult)
        {
            var result = StringRotation.Run(inputOne, inputTwo);
            Assert.Equal(expectedResult, result);
        }
    }
}
