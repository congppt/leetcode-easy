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
                //right bit shift 1 == div by 2 but also help avoid int overflow
                var mid = (start + end) >> 1;

                //IsBadVersion is from leetcode
                //if (IsBadVersion(mid))
                //    end = mid;
                //else start = mid + 1;
            }
            return start;
        }
    }
}
