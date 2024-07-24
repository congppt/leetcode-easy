using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LengthOfLastWordProblem
    {
        public static int LengthOfLastWord(string s)
        {
            var length = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                    length++;
                else if (length != 0) return length;
            }
            return length;
        }
    }
}
