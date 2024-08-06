using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ContainsDuplicateProblem
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> visited = [];
            for (int i = 0; i < nums.Length; i++)
            {
                if (visited.Contains(nums[i])) return true;
                visited.Add(nums[i]);
            }
            return false;
        }
    }
}
