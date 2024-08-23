using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MaxConsecutiveOnesProblem
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            var count= 0;
            var max = 0;
            foreach (var x in nums)
            {
                if (x == 1) count++;
                else count = 0;
                if (count > max) max = count;
            }
            return max;
        }
    }
}
