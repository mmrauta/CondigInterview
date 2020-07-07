namespace CodingInterview.LinkedLists
{
    /// <summary>
    /// Implement an algorithm to delete a node in the middle
    /// (i.e., any node but the first and last node, not necessarily the exact middle)
    /// of a singly linked list, given only access to that node;
    /// </summary>
    public static class DeleteMiddleNode
    {
        public static void Run(Node node)
        {
            if (node?.Next == null)
                return;

            var next = node.Next;

            node.Value = next.Value;
            node.Next = next.Next;
        }
    }
}
