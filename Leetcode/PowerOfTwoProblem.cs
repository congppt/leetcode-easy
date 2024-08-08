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
            return (n & (n - 1)) == 0;
        }
    }
}
