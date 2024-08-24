using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Base7Problem
    {
        public string ConvertToBase7(int num)
        {
            //idk why not asking for computer storing logic like base 16 problem
            var base7String = string.Empty;
            bool isMinus = num < 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                var letterCode = num % 7;
                base7String = letterCode + base7String;
                num = (num - letterCode) / 7;
            }
            if (isMinus) base7String = "-" + base7String;
            return base7String.Length == 0 ? "0" : base7String;
        }
    }
}
