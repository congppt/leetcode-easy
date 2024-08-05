using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class HappyNumberProblem
    {
        public static bool IsHappy(int n)
        {
            HashSet<int> visited = [];
            while (n != 1 && !visited.Contains(n))
            {
                visited.Add(n);
                var sum = 0;
                while (n > 0)
                {
                    sum += (int)Math.Pow(n % 10, 2);
                    n /= 10;
                }
                n = sum;
            }
            return n == 1;
        }
    }
}
