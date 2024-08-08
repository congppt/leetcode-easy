using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PowerOfTwoProblem
    {
        public static bool IsPowerOfTwo(int n)
        {
            if (n <= 0) return false;
            // 101(5) & 110(6) = 100, 111(7) & 1000(8) = 0000
            return (n & (n - 1)) == 0;
        }
    }
}
