using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MoveZeroesProblem
    {
        public static void MoveZeroes(int[] nums)
        {
            var j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    var temp = nums[j];
                    nums[j++] = nums[i];
                    nums[i] = temp;
                }
            }
        }
    }
}
