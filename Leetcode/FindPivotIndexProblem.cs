using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class FindPivotIndexProblem
    {
        public int PivotIndex(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];
            int halfSum = 0;
            for (int i = 0; i < nums.Length; i++){
                if (sum - nums[i] - halfSum == halfSum) return i;
                halfSum += nums[i];
            }
            return-1;
        }
    }
}