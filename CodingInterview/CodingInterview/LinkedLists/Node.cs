namespace CodingInterview.LinkedLists
{
    public class Node
    {
        public Node(int value)
        {
            this.Value = value;
        }

        public int Value { get; set; }

        public Node Next { get; set; }

        /*
         * 5-3-1-4-5-6-1
         */
        public static Node BuildNodeListOne()
        {
            var node = new Node(5);
            node.Next = new Node(3);
            node.Next.Next = new Node(1);
            node.Next.Next.Next = new Node(4);
            node.Next.Next.Next.Next = new Node(5);
            node.Next.Next.Next.Next.Next = new Node(6);
            node.Next.Next.Next.Next.Next.Next = new Node(1);

            return node;
        }
    }
}