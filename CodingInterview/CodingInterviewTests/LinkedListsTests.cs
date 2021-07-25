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

        [Theory]
        [InlineData("3-5-8-5-10-2-1", "32158510")]
        [InlineData("3-5-5-5-10-2", "3255510")]
        [InlineData("2-1", "21")]
        [InlineData("10", "10")]
        [InlineData("", "")]
        public void PartitionTest(string inputList, string expectedResult)
        {
            var input = TestHelpers.ToLinkedList(inputList);
            var result = Partition.Run(input, 5);
            Assert.Equal(expectedResult, TestHelpers.ToString(result));
        }
    }
}