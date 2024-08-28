using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ArrayPartitionProblem
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            var sum = 0;
            for (int i = 0; i < nums.Length; i += 2)
                sum += nums[i];
            return sum;
        }
    }
}
