using System.Collections.Generic;

namespace CodingInterview.LinkedLists
{
    /// <summary>
    /// Write code to remove duplicates from an unsorted linked list.
    /// </summary>
    public static class RemoveDuplicates
    {
        public static Node Run(Node head)
        {
            if(head?.Next == null)
                return head;

            var nodeIds = new HashSet<int> { head.Value };

            var node = head;
            while (node.Next != null)
            {
                var current = node.Next;
                if (nodeIds.Contains(current.Value))
                    node.Next = current.Next;
                else
                {
                    nodeIds.Add(current.Value);
                    node = current;
                }
            }

            return head;
        }
    }
}
