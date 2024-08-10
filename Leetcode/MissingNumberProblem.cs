using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MissingNumberProblem
    {
        public int MissingNumber(int[] nums)
        {
            var total = 0;
            var expected = nums.Length * (nums.Length + 1) / 2;
            foreach(var i in nums) total += i;
            return expected - total;
        }
    }
}
