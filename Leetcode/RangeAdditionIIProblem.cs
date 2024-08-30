using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RangeAdditionIIProblem
    {
        public int MaxCount(int m, int n, int[][] ops)
        {
            if (ops.Length == 0) return m * n;
            var minX = ops[0][0];
            var minY = ops[0][1];
            for (int i = 1; i < ops.Length; i++)
            {
                minX = ops[i][0] < minX ? ops[i][0] : minX;
                minY = ops[i][1] < minY ? ops[i][1] : minY;
            }
            return minX * minY;
        }
    }
}