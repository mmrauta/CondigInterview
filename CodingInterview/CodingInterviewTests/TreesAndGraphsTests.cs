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
    }
}
