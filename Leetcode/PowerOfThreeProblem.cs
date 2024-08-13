using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PowerOfThreeProblem
    {
        public static bool IsPowerOfThree(int n)
        {
            // 1162261467 is 3^19, largest power of 3 in int range
            return n > 0 && 1162261467 % n == 0;
        }
    }
}
