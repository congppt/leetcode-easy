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
                if ((nums[uniqueIndex] ^ nums[i]) == 0) uniqueIndex
            }
            return nums[uniqueIndex];
        }
    }
}
