using System.Collections.Generic;
using System.Linq;

namespace CodingInterview.TreesAndGraphs
{
    /// <summary>
    /// Given a directed graph, design an algorithm to find out whether there is a route between two nodes.
    /// </summary>
    public static class RouteBetweenNodes
    {
        public static bool Run(GraphNode a, GraphNode b)
        {
            var queue = new Queue<GraphNode>();
            var processed = new HashSet<GraphNode>();

            queue.Enqueue(a);
            while (queue.Any())
            {
                var current = queue.Dequeue();
                if (processed.Contains(current))
                    continue;

                if (current == b)
                    return true;

                foreach (var node in current.Adjacent)
                    if (!processed.Contains(node))
                        queue.Enqueue(node);

                processed.Add(current);
            }

            return false;
        }
    }
}