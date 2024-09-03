using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SetMismatchProblem
    {
        public int[] FindErrorNums(int[] nums)
        {
            HashSet<int> check = [];
            int[] errors = new int[2];
            var sum = 0;
            for (int i = 0; i < nums.Length; i++){
                sum += nums[i];
                if (!check.Add(nums[i])) errors[0] = nums[i];
            }
            sum -= errors[0];
            var expectedSum = nums.Length * (nums.Length + 1) / 2;
            errors[1] = expectedSum - sum; 
            return errors;
        }
    }
}