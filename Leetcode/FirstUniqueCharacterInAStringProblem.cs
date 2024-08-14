using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class FirstUniqueCharacterInAStringProblem
    {
        public int FirstUniqChar(string s)
        {
            int[] appearances = new int[26];
            foreach (char c in s)
                appearances[c - 'a']++;
            for (int i = 0; i < s.Length; i++)
                if (appearances[s[i] - 'a'] == 1) return i;
            return -1;
        }
    }
}
