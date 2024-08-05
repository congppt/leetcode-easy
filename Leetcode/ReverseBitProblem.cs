using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ReverseBitProblem
    {
        public static uint reverseBits(uint n)
        {
            uint[] bits = new uint[32];
            var j = 0;
            while (n > 0)
            {
                var spare = n % 2;
                bits[j] = spare;
                n = (n - spare) / 2;
                j++;
            }
            var result = 0u;
            for (int i = 0; i < bits.Length; i++)
            {
                result *= 2;
                result += bits[i];
            }
            return result;
        }
        static uint reverseBitsUseBitShift(uint n)
        {
            var result = 0u;
            var i = 32;
            while (i > 0)
            {
                //left shift 1 bit => adding a 0 bit to the end == x2 current val
                result <<= 1;
                // & operator AND each bit of n with 1 (000000...1)
                // => if last bit of n is 1 then result will be 1 => trye.
                //this process is to check if the last added bit of result above
                //need to change to 1 to match last bit of n which equals 1
                if ((n & 1) == 1)
                    //result = XOR result with 1
                    //=> if last bit is 1 then changed it to 0 and opposite
                    result ^= 1;
                //remove last bit of n
                n >>= 1;
                i--;
            }
            return result;
        }
    }
}
