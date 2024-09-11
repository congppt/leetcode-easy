using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MinCostClimbingStairsProblem
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            var steps = new int[cost.Length + 2];
            for (var i = cost.Length - 1; i >= 0; i--)
                steps[i] = cost[i] + Math.Min(steps[i + 1], steps[i + 2]);
            return Math.Min(steps[0], steps[1]);
            
        }
    }
}