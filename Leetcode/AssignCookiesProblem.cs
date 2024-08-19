using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class AssignCookiesProblem
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            var count = 0;
            Array.Sort(g);
            Array.Sort(s);
            int i = 0, j = 0;
            while (i < g.Length && j < s.Length)
            {
                if (g[i] <= s[j++])
                {
                    count++;
                    i++;
                }
            }
            return count;
        }
    }
}
