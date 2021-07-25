namespace CodingInterview.LinkedLists
{
    /**
     * 
     * Given a linked list and a value x, partition it such that all nodes
     * less than x come before nodes greater than or equal to x.
     * 
     * For example, Given 3->5->8->5->10->2->1 and x=5, return 3->1->2->10->5->5->8 
     */
    public static class Partition
    {
        public static Node Run(Node head, int x)
        {
            if (head?.Next == null)
                return head;

            Node smallerNodesTail = null;
            Node smallerNodeHead = null;

            Node biggerNodesTail = null;
            Node biggerNodesHead = null;

            var node = head;
            while (node!= null)
            {
                if (node.Value < x)
                    AppendNode(ref smallerNodeHead, ref smallerNodesTail, node);
                else
                    AppendNode(ref biggerNodesHead, ref biggerNodesTail, node);

                node = node.Next;
            }

            if (biggerNodesHead is null)
            {
                smallerNodesTail.Next = null;
                return smallerNodeHead;
            }
            else if (smallerNodeHead is null)
            {
                biggerNodesTail.Next = null;
                return biggerNodesHead;
            }
            else
            {
                smallerNodesTail.Next = biggerNodesHead;
                biggerNodesTail.Next = null;
                return smallerNodeHead;
            }
        }

        private static void AppendNode(ref Node head, ref Node tail, Node node)
        {
            if (head is null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }
    }
}
