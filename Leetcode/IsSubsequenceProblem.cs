using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class IsSubsequenceProblem
    {
        public bool IsSubsequence(string s, string t)
        {
            var sub = 0;
            for(int i = 0; i < t.Length && sub < s.Length; i++)
            {
                if (t[i] == s[sub]) sub++;
            }
            return sub == s.Length;
        }
    }
}
