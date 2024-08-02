using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SingleNumberProblem
    {
        public static int SingleNumber(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            var uniqueNumber = 0;

            for (var i = 1; i < nums.Length; i++)
            {
                // a ^ a = 0 (bit diff)
                //a ^ a ^ b = 0 ^ b = b (bit diff)
                uniqueNumber ^= nums[i];
            }
            return uniqueNumber;
        }
    }
}
