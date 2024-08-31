using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MinimumIndexSumOfTwoListsProblem
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<string, int> appearances = [];
            for (int i = 0; i < list1.Length; i++)
                appearances.Add(list1[i], i);
            var minSumIndex = int.MaxValue;
            List<string> results = [];
            for (int j = 0; j < list2.Length; j++)
            {
                if (appearances.ContainsKey(list2[j]))
                {
                    appearances[list2[j]] += j;
                    if (appearances[list2[j]] > minSumIndex) 
                        continue;
                    if (appearances[list2[j]] < minSumIndex)
                    {
                        results.Clear();
                        minSumIndex = appearances[list2[j]];
                    }
                    results.Add(list2[j]);
                }
            }
            return [..results];
        }
    }
}