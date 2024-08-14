using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class IntersectionOfTwoArraysProblem
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> result = [];
            HashSet<int> nums1Values = [];
            foreach (var num in nums1)
                nums1Values.Add(num);
            foreach (var num in nums2)
                if (nums1Values.Contains(num))
                    result.Add(num);
            return [.. result];
        }
    }
}
