using System.Collections.Generic;
using System.Linq;

namespace CodingInterview.RecursionAndDynamicProgramming
{
    /// <summary>
    /// Write a method to return all subsets of a set.
    /// </summary>
    public static class PowerSet
    {
        public static List<List<int>> RunRecursive(List<int> set)
        {
            if(set == null || !set.Any())
                return new List<List<int>>();

            var memo = new Dictionary<int, List<List<int>>>();
            memo[0] = new List<List<int>> { new List<int> { set[0] } };
            return Generate(set, set.Count - 1, memo);
        }

        private static List<List<int>> Generate(List<int> set, int index, Dictionary<int, List<List<int>>> memo)
        {
            if(memo.ContainsKey(index))
                return memo[index];

            var previousSets = Generate(set, index - 1, memo);

            var newSets = previousSets.Select(x => x.Append(set[index]).ToList());

            memo[index] = new List<List<int>>(previousSets);    // add previous items
            memo[index].AddRange(newSets);                      // add each previous set, extended by current item
            memo[index].Add(new List<int>{set[index]});     // add 'current item only' set

            return memo[index];
        }

        public static List<List<int>> RunIterative(List<int> set)
        {
            if (set == null || !set.Any())
                return new List<List<int>>();

            var memo = new Dictionary<int, List<List<int>>>();
            memo[0] = new List<List<int>> { new List<int> { set[0] } };

            for (var i = 1; i < set.Count; i++)
            {
                var previousSets = memo[i - 1];
                var newSets = previousSets.Select(x => x.Append(set[i]).ToList());

                memo[i] = new List<List<int>>(previousSets);
                memo[i].AddRange(newSets);
                memo[i].Add(new List<int>{ set[i] });
            }

            return memo[set.Count - 1];
        }
    }
}
