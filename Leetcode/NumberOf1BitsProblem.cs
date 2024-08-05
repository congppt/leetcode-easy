using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class NumberOf1BitsProblem
    {
        public static int HammingWeight(int n)
        {
            var count = 0;
            while (n > 0)
            {
                var spare = n % 2;
                if (spare == 1) count++; 
                n = (n - spare) / 2;
            }
            return count;
        }
        static int HammingWeightBitShift(int n)
        {
            var count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
    }
}
