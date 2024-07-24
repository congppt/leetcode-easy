using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RemoveDuplicatesFromSortedArrayProblem
    {
        public static int RemoveDuplicates(int[] nums)
        {
            var nextIndex = 1;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[nextIndex] = nums[i];
                    nextIndex++;
                }    
            }
            return nextIndex;
        }
    }
}
