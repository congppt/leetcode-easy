using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MergeSortedArrayProblem
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0) return;
            var end1 = m - 1;
            var end2 = n - 1;
            for (var i = m + n - 1; i >= 0; i--)
            {
                if (end2 < 0 ||(end1 >= 0 && nums1[end1] >= nums2[end2]))
                {
                    nums1[i] = nums1[end1];
                    end1--;
                }
                else
                {
                    nums1[i] = nums2[end2];
                    end2--;
                }
            }
        }
    }
}
