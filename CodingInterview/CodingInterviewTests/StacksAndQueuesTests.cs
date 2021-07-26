using CodingInterview.StacksAndQueues;
using Xunit;

namespace CodingInterviewTests
{
    public class StacksAndQueuesTests
    {
        [Fact]
        public void QueueViaStacksTest()
        {
            var myQueue = new QueueViaStacks<int>();

            // not possible to dequeue from an empty queue
            Assert.Equal(0, myQueue.Length);
            Assert.Throws<System.InvalidOperationException>(() => myQueue.Dequeue());

            // items are added by enqueue
            for (int i = 0; i < 3; i++)
                myQueue.Enqueue(i);

            Assert.Equal(3, myQueue.Length);
            
            // valid values are dequeued
            Assert.Equal(0, myQueue.Dequeue());
            Assert.Equal(1, myQueue.Dequeue());
            Assert.Equal(1, myQueue.Length);

            // enqueing new value doesn't break the dequeue
            myQueue.Enqueue(3);
            Assert.Equal(2, myQueue.Dequeue());

            // peek returns value without removing it from the queue
            Assert.Equal(1, myQueue.Length);
            Assert.Equal(3, myQueue.Peek());
            Assert.Equal(1, myQueue.Length);

            // clear removes all values from the queue
            myQueue.Clear();
            Assert.Equal(0, myQueue.Length);
        }
    }
}
