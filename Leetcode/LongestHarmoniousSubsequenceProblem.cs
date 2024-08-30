using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LongestHarmoniousSubsequenceProblem
    {
        public int FindLHS(int[] nums) {
            int maxLength = 0;
            Dictionary<int, int> appearances = [];
            for (int i = 0; i < nums.Length; i++)
            {
                if (!appearances.TryAdd(nums[i], 1)) 
                    appearances[nums[i]]++;
            }
            foreach(var num in appearances.Keys){
                if (appearances.TryGetValue(num + 1, out var count)){
                    var length = appearances[num] + count;
                    maxLength = length > maxLength ? length : maxLength;
                }
            }
            return maxLength;
        }
    }
}