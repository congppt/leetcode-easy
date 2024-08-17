using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ThirdMaximumNumber
    {
        public static int ThirdMax(int[] nums)
        {
            HashSet<int> vals = [];
            var count = 0;
            var min = nums[0];
            while (count < (nums.Length >= 3 ? 3 : 1))
            {
                count++;
                var max = min;
                for (var i = 0; i < nums.Length; i++)
                {
                    if (vals.Contains(nums[i])) continue;
                    if (nums[i] <= min)
                    {
                        min = nums[i];
                        continue;
                    }
                    if (nums[i] <= max) continue;
                    max = nums[i];
                }
                vals.Add(max);
            }
            return vals.Count == 3 ? vals.Min() : vals.Max();
        }
    }
}
