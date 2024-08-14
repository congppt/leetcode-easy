using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class IntersectionOfTwoArrayIIProblem
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> result = [];
            Dictionary<int, int> numsMap = [];
            foreach (var num in nums1.Length < nums2.Length ? nums1 : nums2)
            {
                if (!numsMap.TryAdd(num, 1))
                    numsMap[num]++;
            }
            foreach (var num in nums1.Length < nums2.Length ? nums2 : nums1)
            {
                if (!numsMap.TryGetValue(num, out int count) || count <= 0)
                    continue;
                result.Add(num);
                numsMap[num]--;
                
            }
            return [..result];
        }
    }
}
