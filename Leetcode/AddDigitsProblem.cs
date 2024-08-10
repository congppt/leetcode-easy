using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class AddDigitsProblem
    {
        public static int AddDigits(int num)
        {
            if (num == 0) return 0;
            return num % 9 == 0 ? 9 : num % 9;
        }
    }
}
