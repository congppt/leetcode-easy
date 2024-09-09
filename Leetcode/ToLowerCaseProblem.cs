using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ToLowerCaseProblem
    {
        public string ToLowerCase(string s)
        {
            var builder = new StringBuilder();
            for(int i = 0; i < s.Length; i++)
                builder.Append(s[i] <= 'Z' && s[i] >= 'A' ? (char)(s[i] + 32) : s[i]);
            return builder.ToString();
        }
    }
}