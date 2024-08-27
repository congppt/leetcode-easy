using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LongestUncommonSubsequenceIProblem
    {
        public int FindLUSlength(string a, string b)
        {
            if (a == b) return -1;
            return a.Length > b.Length ? a.Length : b.Length;
        }
    }
}
