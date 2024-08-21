using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class NumberComplementProblem
    {
        public int FindComplement(int num)
        {
            uint mask = 1;
            while (mask <= num)
                mask <<= 1;
            return (int)(num ^ (mask - 1));
        }
    }
}
