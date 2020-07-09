using System.Collections.Generic;
using System.Linq;

namespace CodingInterview.RecursionAndDynamicProgramming
{
    /// <summary>
    /// Imagine a robot sitting on the upper left corner of grid with r rows and c columns.
    /// The robot can only move in two directions, right and down, but certain cells are 'off limits' such that the robot cannot step on them.
    /// Design an algorithm to find a path for the robot from the top left to the bottom right.
    /// </summary>
    public static class RobotInGrid
    {
        public static List<(int, int)> RunWithQueue(int[][] grid)
        {
            if (grid == null)
                return new List<(int, int)>();

            var rowsCount = grid.Length;
            var columnsCount = grid[0].Length;

            var visited = new HashSet<(int,int)>();
            var queue = new Queue<(int r, int c, List<(int, int)> paths)>();

            queue.Enqueue((0,0, new List<(int, int)>()));
            while (queue.Any())
            {
                var current = queue.Dequeue();
                if (visited.Contains((current.r, current.c)))
                    continue;

                visited.Add((current.r, current.c));
                current.paths.Add((current.r, current.c));

                if (current.r == rowsCount - 1 && current.c == columnsCount - 1)
                    return current.paths;

                if (current.c + 1 < columnsCount && grid[current.r][current.c + 1] != 1)
                    queue.Enqueue((current.r, current.c + 1, new List<(int, int)> (current.paths)));

                if (current.r + 1 < rowsCount && grid[current.r + 1][current.c] != 1)
                    queue.Enqueue((current.r + 1, current.c, new List<(int, int)> (current.paths)));
            }

            return new List<(int, int)>();
        }

        public static List<(int, int)> RunWithStack(int[][] grid)
        {
            if (grid == null)
                return new List<(int, int)>();

            var rowsCount = grid.Length;
            var columnsCount = grid[0].Length;

            var visited = new HashSet<(int, int)>();
            var stack = new Stack<(int r, int c, List<(int, int)> paths)>();

            stack.Push((0, 0, new List<(int, int)>()));
            while (stack.Any())
            {
                var current = stack.Pop();
                if (visited.Contains((current.r, current.c)))
                    continue;

                current.paths.Add((current.r, current.c));
                visited.Add((current.r, current.c));

                if (current.r == rowsCount - 1 && current.c == columnsCount - 1)
                    return current.paths;

                if (current.c + 1 < columnsCount && grid[current.r][current.c + 1] != 1)
                    stack.Push((current.r, current.c + 1, new List<(int, int)> (current.paths)));

                if (current.r + 1 < rowsCount && grid[current.r + 1][current.c] != 1)
                    stack.Push((current.r + 1, current.c, new List<(int, int)> (current.paths)));
            }

            return new List<(int, int)>();
        }

        public static List<(int, int)> RunRecursive(int[][] grid)
        {
            if (grid == null)
                return new List<(int, int)>();

            var visited = new HashSet<(int, int)>();
            var path = new List<(int, int)>();

            var hasPath = GetPath(grid, 0, 0, path, visited);
            return hasPath ? path : new List<(int, int)>();
        }

        private static bool GetPath(int[][] grid, int r, int c, List<(int, int)> path, HashSet<(int, int)> visited)
        {
            if (r >= grid.Length || c >= grid[0].Length || grid[r][c] == 1)
                return false;

            var current = (row: r, col: c);
            if (visited.Contains(current))
                return false;

            visited.Add(current);
            path.Add((r, c));

            var reachedEnd = r == grid.Length - 1 && c == grid[0].Length - 1;

            return reachedEnd || GetPath(grid, r, c + 1, path, visited) || GetPath(grid, r + 1, c, path, visited);
        }
    }
}
