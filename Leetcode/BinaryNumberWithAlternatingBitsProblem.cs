using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class BinaryNumberWithAlternatingBitsProblem
    {
        public bool HasAlternatingBits(int n)
        {
            //if n is valid, then n ^ (n >> 1) will have the form 111111111... highest power of 2 <= n and minus 1
            //otherwise there will be '0' bits 
            n ^= n >> 1;
            // n + 1 == power of 2
            // n & (n + 1) = ...01111 & ...10000 = 0
            // if n is not 1111... then n + 1 will not be power of  2 
            // => most significant bit not change => n & (n + 1) != 0
            return (n & n + 1) == 0;
        }
    }
}