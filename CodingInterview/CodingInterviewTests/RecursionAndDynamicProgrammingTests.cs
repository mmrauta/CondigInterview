using CodingInterview.RecursionAndDynamicProgramming;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CodingInterviewTests
{
    public class RecursionAndDynamicProgrammingTests
    {
        [Fact]
        public void TripleStepTest()
        {
            var resultRecursive = TripleStep.RunRecursive(3);
            Assert.Equal(4, resultRecursive);

            var resultIterative = TripleStep.RunIterative(3);
            Assert.Equal(4, resultIterative);
        }

        [Fact]
        public void RobotInGridTest()
        {
            var input = TestHelpers.BuildJaggedGridEight();

            var resultQueue = RobotInGrid.RunWithQueue(input);
            Assert.Equal(new List<(int, int)> { (0, 0), (0, 1), (0, 2), (0, 3), (1, 3), (2, 3) }, resultQueue);

            var resultStack = RobotInGrid.RunWithStack(input);
            Assert.Equal(new List<(int, int)> { (0, 0), (0, 1), (1, 1), (2, 1), (2, 2), (2, 3) }, resultStack);

            var resultRecursive= RobotInGrid.RunRecursive(input);
            Assert.Equal(new List<(int, int)> { (0, 0), (0, 1), (0, 2), (0, 3), (1, 3), (2, 3) }, resultRecursive);
        }

        [Theory]
        [InlineData(new int[] { }, null)]
        [InlineData(new[] { 1, 3, 5, 6, 7 }, null)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 11, 12, 22, 127 }, null)]
        [InlineData(new[] { -11, -2, 0, 1, 2, 3, 4, 7, 22, 127 }, 7)]
        [InlineData(new[] { -5, -4, -2, 3, 5, 6, 11, 13, 22, 127 }, 3)]
        public void MagicIndexTest(int[] input, int? expectedResult)
        {
            var resultRecursive = MagicIndex.Run(input);
            Assert.Equal(expectedResult, resultRecursive);
        }

        [Theory]
        [InlineData(new int[] { }, null)]
        [InlineData(new[] { 1, 3, 5, 6, 7 }, null)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 11, 12, 22, 127 }, null)]
        [InlineData(new[] { -2, -2, 0, 1, 2, 7, 7, 7, 22, 127 }, 7)]
        [InlineData(new[] { 1, 1, 1, 1, 1, 1, 1, 13, 22, 127 }, 1)]
        public void MagicIndexWithDuplicatesTest(int[] input, int? expectedResult)
        {
            var resultRecursive = MagicIndex.RunWithDuplicates(input);
            Assert.Equal(expectedResult, resultRecursive);
        }

        [Fact]
        public void PowerSetTest()
        {
            var input = new List<int> {1, 3, 5 };
            var expected = new List<List<int>> {
                new List<int> {1}, new List<int> {1, 3}, new List<int> {1, 5}, new List<int> {1, 3, 5},
                new List<int> {3}, new List<int> {3, 5},
                new List<int> {5}
            }.OrderBy(x => x.First()).ToList();

            var resultRecursive = PowerSet.RunRecursive(input);
            var resultIterative = PowerSet.RunIterative(input);

            Assert.Equal(expected, resultRecursive.OrderBy(x => x.First()));
            Assert.Equal(expected, resultIterative.OrderBy(x => x.First()));
        }
    }
}
