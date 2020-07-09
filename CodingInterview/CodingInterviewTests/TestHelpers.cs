using CodingInterview.LinkedLists;
using CodingInterview.TreesAndGraphs;
using System.Text;

namespace CodingInterviewTests
{
    public static class TestHelpers
    {
        public static string ToString(this int[][] input)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    builder.Append(input[i][j]);
                }
            }

            return builder.ToString();
        }

        public static string ToString(this Node input)
        {
            var builder = new StringBuilder();
            
            var node = input;
            while (node != null)
            {
                builder.Append(node.Value);
                node = node.Next;
            }

            return builder.ToString();
        }

        public static string ToString(this TreeNode input)
        {
            var builder = new StringBuilder();
            DFS(input, builder);
            return builder.ToString();
        }

        /*[
         * [1,2,3],
         * [8,9,4],
         * [7,6,5]
         * ]
         */
        public static int[][] BuildJaggedGridOne()
        {
            return new int[][] { new[] { 1, 2, 3 }, new[] { 8, 9, 4 }, new[] { 7, 6, 5 } };
        }

        /*[
         * [1,2,3,4],
         * [1,2,3,5],
         * [9,8,7,6],
         * [1,2,3,4]
         * ]
         */
        public static int[][] BuildJaggedGridTwo()
        {
            return new int[][] { new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 5 }, new[] { 9, 8, 7, 6 }, new[] { 1, 2, 3, 4} };
        }

        /*[
         * [1,2],
         * [3,4]
         * ]
         */
        public static int[][] BuildJaggedGridThree()
        {
            return new int[][] { new[] { 1, 2 }, new[] { 3, 4 } };
        }

        /*[
         * [1,2,3,4],
         * [1,2,0,5],
         * [9,8,7,6],
         * [1,0,3,4]
         * ]
         */
        public static int[][] BuildJaggedGridFive()
        {
            return new int[][] { new[] { 1, 2, 3, 4 }, new[] { 1, 2, 0, 5 }, new[] { 9, 8, 7, 6 }, new[] { 1, 0, 3, 4 } };
        }

        /*[
         * [0,2,3],
         * [8,0,4],
         * [7,6,0]
         * ]
         */
        public static int[][] BuildJaggedGridSix()
        {
            return new int[][] { new[] { 0, 2, 3 }, new[] { 8, 0, 4 }, new[] { 7, 6, 0 } };
        }

        /*[
         * [1,2,3,4],
         * [1,2,0,5],
         * [9,8,7,6]
         * ]
         */
        public static int[][] BuildJaggedGridSeven()
        {
            return new int[][] { new[] { 1, 2, 3, 4 }, new[] { 1, 2, 0, 5 }, new[] { 9, 8, 7, 6 } };
        }

        /*[
         * [0,0,0,0],
         * [1,0,1,0],
         * [1,0,0,0]
         * ]
         */
        public static int[][] BuildJaggedGridEight()
        {
            return new int[][] { new[] { 0, 0, 0, 0 }, new[] { 1, 0, 1, 0 }, new[] { 1, 0, 0, 0 } };
        }

        private static void DFS(TreeNode node, StringBuilder builder)
        {
            if (node == null)
                return;

            DFS(node.Left, builder);
            builder.Append(node.Value);
            DFS(node.Right, builder);
        }
    }
}
