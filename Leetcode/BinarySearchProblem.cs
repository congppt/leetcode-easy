using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class BinarySearchProblem
    {
        public int Search(int[] nums, int target) {
            int start = 0, end = nums.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target) return mid;
                if (nums[mid] > target) end = mid - 1;
                else start = mid + 1;
            }
            return -1;
        }
    }
}