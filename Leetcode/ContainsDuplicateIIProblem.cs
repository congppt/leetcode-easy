using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ContainsDuplicateIIProblem
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums.Length == 1 || k == 0) return false;
            HashSet<int> visited = [];
            var left = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                // current index - minimum possible > k
                // then remove visited element at minimum and increase minimum
                if (right - left > k)
                {
                    visited.Remove(nums[left]);
                    left++;
                }
                if (visited.Contains(nums[right])) return true;
                visited.Add(nums[right]);
            }
            return false;
        }
    }
}
