using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PowerOfFourProblem
    {
        public bool IsPowerOfFour(int n)
        {
            var mask = 0b01010101010101010101010101010101;
            return ((n & (n - 1)) == 0) &&((mask & n) != 0);
        }
    }
}
