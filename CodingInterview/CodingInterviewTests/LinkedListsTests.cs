using CodingInterview.LinkedLists;
using Xunit;

namespace CodingInterviewTests
{
    public class LinkedListsTests
    {
        [Fact]
        public void RemoveDuplicatesTest()
        {
            var input = Node.BuildNodeListOne();
            var result = RemoveDuplicates.Run(input);
            Assert.Equal("53146", TestHelpers.ToString(result));
        }

        [Theory]
        [InlineData(2, "561")]
        [InlineData(0, "1")]
        [InlineData(10, "5314561")]
        [InlineData(-4, "")]
        public void ReturnKthToLastTest(int k, string expectedResult)
        {
            var input = Node.BuildNodeListOne();
            var result = ReturnKthToLast.Run(input, k);
            Assert.Equal(expectedResult, TestHelpers.ToString(result));
        }

        [Fact]
        public void DeleteMiddleNodeTest()
        {
            var input = Node.BuildNodeListOne();
            DeleteMiddleNode.Run(input.Next.Next);
            Assert.Equal("534561", TestHelpers.ToString(input));

            DeleteMiddleNode.Run(input.Next.Next.Next);
            Assert.Equal("53461", TestHelpers.ToString(input));
        }
    }
}
