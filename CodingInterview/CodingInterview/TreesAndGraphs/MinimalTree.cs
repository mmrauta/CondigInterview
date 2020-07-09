namespace CodingInterview.TreesAndGraphs
{
    /// <summary>
    /// Given a sorted (increasing order) array with unique integer elements,
    /// write an algorithm to create a binary search tree with minimal height
    /// </summary>
    public static class MinimalTree
    {
        public static TreeNode Run(int[] input)
        {
            if (input == null || input.Length == 0)
                return null;

            return Propagate(input, 0, input.Length - 1);
        }

        private static TreeNode Propagate(int[] input, int start, int end)
        {
            if (end < start)
                return null;

            var midPoint = (start + end) / 2;
            var newNode = new TreeNode(input[midPoint]);

            newNode.Left = Propagate(input, start, midPoint - 1);
            newNode.Right = Propagate(input, midPoint + 1, end);

            return newNode;
        }
    }
}
