using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RangeSumQueryImmutableProblem
    {
        public class NumArray
        {
            private readonly int[] _nums;
            public NumArray(int[] nums)
            {
                _nums = new int[nums.Length + 1];
                for (int i = 1; i < _nums.Length; i++)
                    _nums[i] = _nums[i - 1] + nums[i];
            }

            public int SumRange(int left, int right)
            {
                return _nums[right + 1] - _nums[left];
            }
        }
    }
}
