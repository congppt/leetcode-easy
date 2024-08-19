using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ArrangingCoinsProblem
    {
        public int ArrangeCoins(int n)
        {
            //faster solution require type casting
            var i = 0;
            while (n > i)
                n -= ++i;
            return i;
        }
    }
}
