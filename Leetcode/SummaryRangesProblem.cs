using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SummaryRangesProblem
    {
        public static IList<string> SummaryRanges(int[] nums)
        {
            if (nums.Length == 0) return [];
            var lastStart = nums[0];
            List<string> result = [];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1] + 1) continue;
                if (lastStart != nums[i - 1])
                    result.Add($"{lastStart}->{nums[i - 1]}");
                else result.Add(lastStart.ToString());
                lastStart = nums[i];
            }
            if (lastStart == nums[^1]) result.Add(lastStart.ToString());
            else result.Add($"{lastStart}->{nums[^1]}");
            return result;
        }
    }
}
