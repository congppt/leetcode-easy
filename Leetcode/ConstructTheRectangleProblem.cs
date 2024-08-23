using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ConstructTheRectangleProblem
    {
        public static int[] ConstructRectangle(int area)
        {
            var closestToSqrt = (int) Math.Sqrt(area);
            while (closestToSqrt > 1)
            {
                if (area % closestToSqrt == 0) return [area / closestToSqrt, closestToSqrt];
                closestToSqrt--;
            }
            return [area, 1];
        }
    }
}
