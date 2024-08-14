using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class FindTheDifferenceProblem
    {
        public static char FindTheDifference(string s, string t)
        {
            int diff = 0;
            for (int i = 0; i < s.Length; i++)
            {
                diff -= s[i];
                diff += t[i];
            }
            diff += t[^1];
            return (char)diff;
        }
    }
}
