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
            //can use Math.Sqrt instead
            int sqrt = 0;
            int start = 1;
            int end = num;
            while (start <= end)
            {
                //right bit shift help avoid int overflow
                //shift 1 bit == div by 2
                int mid = start + (end - start) / 2;
                sqrt = num / mid;
                if (sqrt == mid) break;
                if (sqrt < mid)
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            sqrt = sqrt < end ? sqrt : end;
            //
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
