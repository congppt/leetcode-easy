using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MaximumProductOfThreeNumbersProblem
    {
        public static int MaximumProduct(int[] nums)
        {
            int min = int.MaxValue, min2 = int.MaxValue, max = int.MinValue, max2 = int.MinValue, max3 = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] < min)
                {
                    min2 = min;
                    min = nums[i];
                }
                else if (nums[i] < min2) min2 = nums[i];

                if (nums[i] >= max)
                {
                    max3 = max2;
                    max2 = max;
                    max = nums[i];
                }
                else if (nums[i] >= max2)
                {
                    max3 = max2;
                    max2 = nums[i];
                }
                else if (nums[i] >= max3) max3 = nums[i];
            }
            return min * min2 * max > max2 * max3 * max ? min * min2 * max : max2 * max3 * max;
        }
    }
}