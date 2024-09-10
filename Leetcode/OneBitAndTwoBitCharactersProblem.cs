using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class OneBitAndTwoBitCharactersProblem
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            int i = 0;
            while(i < bits.Length - 1)
            {
                if (bits[i++] == 1){
                    i++;
                };
            }
            return i == bits.Length - 1;
        }
    }
}