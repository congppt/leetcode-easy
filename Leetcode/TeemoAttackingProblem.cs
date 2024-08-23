using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class TeemoAttackingProblem
    {
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            int total = duration;
            for (int i = 1; i < timeSeries.Length; i++)
            {
                var poisonTime = duration;
                if (timeSeries[i] <= timeSeries[i - 1] + duration - 1)
                    poisonTime = timeSeries[i] - timeSeries[i - 1];
                total += poisonTime;
            }
            return total;
        }
    }
}
