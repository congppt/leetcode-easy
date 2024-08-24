using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RelativeRanksProblem
    {
        public string[] FindRelativeRanks(int[] score)
        {
            string[] podium = ["Gold Medal", "Silver Medal", "Bronze Medal"];
            Dictionary<int, int> appearances = [];
            for (int i = 0; i < score.Length; i++)
                appearances[score[i]] = i;
            var pos = score.OrderDescending().ToArray();
            var result = new string[score.Length];
            for (int i = 0;i < score.Length; i++)
            {
                var index = appearances[pos[i]];
                result[index] = i < 3 ? podium[i] : (i + 1).ToString();
            }
            return result;
        }
    }
}
