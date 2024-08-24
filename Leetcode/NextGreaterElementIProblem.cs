using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class NextGreaterElementIProblem
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length];
            Dictionary<int, int> map = [];
            Stack<int> cache = [];
            for(int i = 0; i < nums1.Length; i++)
            {
                map[nums1[i]] = i;
                result[i] = -1;
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                while (cache.Count > 0 && nums2[i] > cache.Peek())
                {
                    var index = map[cache.Pop()];
                    result[index] = nums2[i];
                }
                if (map.ContainsKey(nums2[i]))
                    cache.Push(nums2[i]);
            }
            return result;
        }
    }
}
