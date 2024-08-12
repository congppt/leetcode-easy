using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class FirstBadVersionProblem
    {
        public static int FirstBadVersion(int n)
        {
            var start = 1;
            var end = n;
            while (start <= end)
            {
                // not (start + end) / 2 to avoid int overflow 
                var mid = start + (end - start) / 2;
                if (IsBadVersion(mid))
                    end = mid
                else start = mid + 1;
            }
            return start;
        }
    }
}
