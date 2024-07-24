using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RemoveElementProblem
    {
        public static int RemoveElement(int[] nums, int val)
        {
            var currentIndex = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[currentIndex] = nums[i];
                    currentIndex++;
                }
            }
            return currentIndex;
        }
    }
}
