using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ValidPerfectSquareProblem
    {
        public bool IsPerfectSquare(int num)
        {
            if (num == 1) return true;
            int start = 1;
            int end = num;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                int quotient = num / mid;
                if (quotient == mid && num % mid == 0) return true;
                if (quotient > mid)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return false;
        }
    }
}
