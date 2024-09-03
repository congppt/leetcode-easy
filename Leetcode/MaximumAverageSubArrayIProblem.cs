using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MaximumAverageSubArrayIProblem
    {
        public double FindMaxAverage(int[] nums, int k) {
            var max = 0;
            for (int i = 0; i < k; i++) max += nums[i];
            var currentSum = max;
            for (int i = k; i < nums.Length; i++){
                currentSum += nums[i] - nums[i - k];
                if (currentSum > max) 
                    max = currentSum;                
            }
            return max * 1.0 / k;
        }
    }
}