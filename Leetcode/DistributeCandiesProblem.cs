using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class DistributeCandiesProblem
    {
        public int DistributeCandies(int[] candyType)
        {
            HashSet<int> types = [];
            for (int i = 0; i < candyType.Length; i++)
                types.Add(candyType[i]);
            return types.Count > candyType.Length / 2 ? candyType.Length / 2 : types.Count;
        }
    }
}