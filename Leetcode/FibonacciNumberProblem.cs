using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class FibonacciNumberProblem
    {
        public int Fib(int n)
        {
            if (n == 0 || n == 1) return n;
            int[] sum = new int[n + 1];
            sum[0] = 0;
            sum[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                sum[i] = sum[i - 1] + sum[i - 2];
            }
            return sum[n];
        }
    }
}
