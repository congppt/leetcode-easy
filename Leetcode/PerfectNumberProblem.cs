using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PerfectNumberProblem
    {
        public bool CheckPerfectNumber(int num)
        {
            if (num == 1) return false;
            var sum = 1;
            int sqrt = (int)Math.Sqrt(num);
            for (int i = 2; i <= sqrt; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    var quotient = num / i;
                    if (quotient != i) sum += quotient;
                }
            }
            return sum == num;
        }
    }
}
