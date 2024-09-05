using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LongestContinuousIncreasingSubsequenceProblem
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            var maxLength = 1;
            var currentLength = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    maxLength = maxLength < currentLength ? currentLength : maxLength;
                    currentLength = 0;
                }
                currentLength++;
            }
            maxLength = maxLength < currentLength ? currentLength : maxLength;
            return maxLength;
        }
    }
}