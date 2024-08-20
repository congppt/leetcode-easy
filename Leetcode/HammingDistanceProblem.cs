using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class HammingDistanceProblem
    {
        public int HammingDistance(int x, int y)
        {
            //xor help mark bit diff pos by value 1
            var xor = x ^ y;
            if (xor == 1) return 1;
            //count number of bit 1
            var count = 0;
            while (xor > 0)
            {
                if ((xor & 1) == 1) count++;
                xor >>= 1;
            }
            return count;
        }
    }
}
