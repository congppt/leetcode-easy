using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ClimbingStairsProblem
    {
        public static int ClimbStairs(int n)
        {
            //smallest trees
            if (n <= 2) return n;
            var steps = 0;
            //tree of 2 step
            var minus1Steps  = 2;
            //tree of 1 step
            var minus2Steps = 1;
            //tree of n = tree of n -1 merging with n - 2
            for (int i = 3;  i <= n; i++)
            {
                steps = minus1Steps + minus2Steps;
                minus2Steps = minus1Steps;
                minus1Steps = steps;
            }
            return steps;
        }
    }
}
