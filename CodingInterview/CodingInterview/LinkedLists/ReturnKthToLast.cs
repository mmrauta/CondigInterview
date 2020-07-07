namespace CodingInterview.LinkedLists
{
    /// <summary>
    /// Implement an algorithm to find the kth to last element of a singly linked list.
    /// </summary>
    public static class ReturnKthToLast
    {
        public static Node Run(Node head, int k)
        {
            if (head == null ||  k < 0)
                return null;

            var p1 = head;
            var p2 = head;

            // set distance (of the length k) between p1 and p2
            for (var i = 0; i < k; i++)
            {
                if (p2 == null)
                    return head;

                p2 = p2.Next;
            }

            while (p2 != null)
            {
                if (p2.Next == null)
                    return p1;

                p1 = p1.Next;
                p2 = p2.Next;
            }

            return head;
        }
    }
}
