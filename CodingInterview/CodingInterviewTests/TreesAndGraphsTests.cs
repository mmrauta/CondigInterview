using CodingInterview.TreesAndGraphs;
using Xunit;

namespace CodingInterviewTests
{
    public class TreesAndGraphsTests
    {
        [Fact]
        public void RouteBetweenNodesTest()
        {
            var (a, b) = GraphNode.GetConnected();
            var resultOne = RouteBetweenNodes.Run(a, b);
            Assert.True(resultOne);

            var (c, d) = GraphNode.GetNotConnected();
            var resultTwo = RouteBetweenNodes.Run(c, d);
            Assert.False(resultTwo);
        }

        [Theory]
        [InlineData(new int[] { }, "")]
        [InlineData(new[] { 1, 3, 5, 6, 7 }, "13567")]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 11, 12, 22, 127 }, "123456111222127")]
        public void MinimalTreeTest(int[] input, string expectedResult)
        {
            var result = MinimalTree.Run(input);
            Assert.Equal(expectedResult, TestHelpers.ToString(result));
        }

        [Fact]
        public void ListOfDepthsTest()
        {
            var inputOne = TreeNode.BuildTreeOne();
            var resultOne = ListOfDepths.Run(inputOne);
            Assert.Equal(5, resultOne[0].Value);
            Assert.Equal(3, resultOne[1].Value);
            Assert.Equal(7, resultOne[1].Next.Value);
            Assert.Equal(1, resultOne[2].Value);
            Assert.Equal(6, resultOne[2].Next.Value);
            Assert.Equal(3, resultOne.Count);


            var inputTwo = TreeNode.BuildTreeTwo();
            var resultTwo = ListOfDepths.Run(inputTwo);
            Assert.Equal(3, resultTwo[0].Value);
            Assert.Equal(6, resultTwo[1].Value);
            Assert.Equal(5, resultTwo[2].Value);
            Assert.Equal(7, resultTwo[2].Next.Value);
            Assert.Equal(3, resultTwo.Count);
        }
    }
}
