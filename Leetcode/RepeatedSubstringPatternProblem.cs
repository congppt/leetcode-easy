using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RepeatedSubstringPatternProblem
    {
        public bool RepeatedSubstringPattern(string s)
        {
            //if s = n pattern combined (n >= 2) then 2s = 2n pattern combined
            //subtract 1st and last letter of 2s
            //=> 2n - 2 pattern >= n pattern => s appear in middle of 2s
            //if s = pattern + some char + pattern ... => s will not appear in middle of 2s since relative position of some char has changed
            string doubled = s + s;
            doubled = doubled.Substring(1, doubled.Length - 2);
            return doubled.Contains(s);
        }
    }
}
