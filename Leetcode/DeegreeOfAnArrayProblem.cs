using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Leetcode
{
    public class DeegreeOfAnArrayProblem
    {
        public int FindShortestSubArray(int[] nums)
        {
            int maxFrequency = 0;
            int[] frequencies = new int[50000];
            Dictionary<int, int> firstAppearances = [];
            Dictionary<int, int> lastAppearances = [];
            for (int i = 0; i < nums.Length; i++){
                frequencies[nums[i]]++;
                if (frequencies[nums[i]] > maxFrequency)
                    maxFrequency = frequencies[nums[i]];
                if (!firstAppearances.TryAdd(nums[i], i))
                    lastAppearances[nums[i]] = i;
                else lastAppearances.Add(nums[i], i);
            }
            int minLength = int.MaxValue;
            for (int i = 0; i < frequencies.Length; i++){
                if (frequencies[i] != maxFrequency) continue;
                int firstAppearance = firstAppearances[i];
                int lastAppearance = lastAppearances[i];
                if (minLength > lastAppearance - firstAppearance + 1) 
                    minLength = lastAppearance - firstAppearance + 1;
            }
            return minLength;
        }
    }
}