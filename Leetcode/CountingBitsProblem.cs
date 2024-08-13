using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class CountingBitsProblem
    {
        public int[] CountBits(int n)
        {
            var result = new int[n + 1];
            int lastPower2 = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i == lastPower2 * 2)
                    lastPower2 = i;
                result[i] = 1 + result[i - lastPower2];
            }
            return result;
        }
    }
}
