using System.Collections.Generic;
using System.Linq;

namespace CodingInterview.StacksAndQueues
{
    /// <summary>
    /// Implement a Queue class that implements a queue using two stacks.
    /// </summary>
    /// <typeparam name="T">Type of the items stored by the queue.</typeparam>
    public class QueueViaStacks<T>
    {
        private Stack<T> stackIn = new Stack<T>();
        private Stack<T> stackOut = new Stack<T>();

        public int Length => stackIn.Count + stackOut.Count;

        public void Enqueue(T item)
        {
            stackIn.Push(item);
        }

        public T Dequeue()
        {
            MoveInToOutIfNeeded();
            return stackOut.Pop();
        }

        public T Peek()
        {
            MoveInToOutIfNeeded();
            return stackOut.Peek();
        }

        public void Clear()
        {
            stackIn.Clear();
            stackOut.Clear();
        }

        private void MoveInToOutIfNeeded()
        {
            if (stackOut.Any())
                return;

            while (stackIn.Any())
                stackOut.Push(stackIn.Pop());
        }
    }
}
