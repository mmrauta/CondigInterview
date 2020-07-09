using CodingInterview.LinkedLists;
using System.Collections.Generic;
using System.Linq;

namespace CodingInterview.TreesAndGraphs
{
    /// <summary>
    /// Given a binary tree, design an algorithm which creates a linked list of all the nodes at each depth.
    /// </summary>
    public static class ListOfDepths
    {
        public static List<Node> Run(TreeNode root)
        {
            if (root == null)
                return new List<Node>();

            var depths = new List<Node>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var queueLength = queue.Count;

                Node previousListNode = null;
                for (var i = 0; i < queueLength; i++)
                {
                    var node = queue.Dequeue();
                    if(node.Left != null)
                        queue.Enqueue(node.Left);

                    if (node.Right != null)
                        queue.Enqueue(node.Right);

                    if (previousListNode == null)
                    {
                        previousListNode = new Node(node.Value);
                        depths.Add(previousListNode);
                    }
                    else
                    {
                        previousListNode.Next = new Node(node.Value);
                        previousListNode = previousListNode.Next;
                    }
                }
            }

            return depths;
        }
    }
}
