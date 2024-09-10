using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SelfDividingNumberProblem
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> result = [];
            while (left <= right)
            {
                if (IsSelfDividingNumber(left)) result.Add(left);
                left++;
            }
            return result;
        }
        bool IsSelfDividingNumber(int num)
        {
            var n = num;
            while (n > 0)
            {
                var digit = n % 10;
                if (digit == 0 || num % digit != 0) return false;
                n /= 10;
            }
            return true;
        }
    }


}