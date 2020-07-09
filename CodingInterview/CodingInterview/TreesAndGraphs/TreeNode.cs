namespace CodingInterview.TreesAndGraphs
{
    public class TreeNode
    {
        public TreeNode(int value)
        {
            this.Value = value;
        }

        public int Value { get; set; }

        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }

        /*
         *      5
         *     / \
         *    3   7
         *   /   /
         *  1   6
         */
        public static TreeNode BuildTreeOne()
        {
            var tree = new TreeNode(5)
            {
                Left = new TreeNode(3),
                Right = new TreeNode(7)
            };

            tree.Left.Left = new TreeNode(1);
            tree.Right.Left = new TreeNode(6);

            return tree;
        }

        /*
         *      3
         *       \
         *        6
         *       / \
         *      5   7
         */
        public static TreeNode BuildTreeTwo()
        {
            var three = new TreeNode(3)
            {
                Right = new TreeNode(6)
            };

            three.Right.Left = new TreeNode(5);
            three.Right.Right = new TreeNode(7);

            return three;
        }

        /*
         *       3
         *     /   \
         *    5     1
         *   / \   / \
         *  6  2   0  8
         *    / \
         *   7   4
         */
        public static TreeNode BuildTreeThree()
        {
            var three = new TreeNode(3)
            {
                Left = new TreeNode(5),
                Right = new TreeNode(1)
            };

            three.Right.Left = new TreeNode(0);
            three.Right.Right = new TreeNode(8);

            three.Left.Left = new TreeNode(6);
            three.Left.Right = new TreeNode(2);

            three.Left.Right.Left = new TreeNode(7);
            three.Left.Right.Right = new TreeNode(4);

            return three;
        }

        /*
         *       3
         *     /   \
         *    5     1
         *   / \   / \
         *  6  2   0  8
         *    / \      \
         *   7   4      2
         */
        public static TreeNode BuildTreeFour()
        {
            var three = new TreeNode(3)
            {
                Left = new TreeNode(5),
                Right = new TreeNode(1)
            };

            three.Right.Left = new TreeNode(0);
            three.Right.Right = new TreeNode(8);
            three.Right.Right.Right = new TreeNode(2);

            three.Left.Left = new TreeNode(6);
            three.Left.Right = new TreeNode(2);

            three.Left.Right.Left = new TreeNode(7);
            three.Left.Right.Right = new TreeNode(4);

            return three;
        }

        /*
         *      2
         *     / \
         *    7   4
         *       /
         *      0
         */
        public static TreeNode BuildTreeThreeFakeSubtree()
        {
            var three = new TreeNode(2)
            {
                Left = new TreeNode(7),
                Right = new TreeNode(4)
            };

            three.Right.Left = new TreeNode(0);

            return three;
        }

        /*
         *      2
         *     / \
         *    7   4
         */
        public static TreeNode BuildTreeThreeSubtree()
        {
            var three = new TreeNode(2)
            {
                Left = new TreeNode(7),
                Right = new TreeNode(4)
            };

            return three;
        }
    }
}
