using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LargestNumberAtLeastTwiceOfOthersProblem
    {
        public int DominantIndex(int[] nums)
        {
            int secondMax = int.MinValue, maxIndex = 0;
            for (int i = 1; i < nums.Length; i++){
                if (nums[i] > nums[maxIndex]){
                    secondMax = nums[maxIndex];
                    maxIndex = i;
                } else if (nums[i] > secondMax)
                    secondMax = nums[i];               
            }
            if (nums[maxIndex] < secondMax * 2) return -1;
            return maxIndex;
        }
    }
}