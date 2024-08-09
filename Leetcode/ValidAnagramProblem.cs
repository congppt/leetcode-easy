using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ValidAnagramProblem
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            int[] chars = new int[256];
            foreach (char c in s) chars[c]++;
            foreach (char c in t)
            {
                if (chars[c] == 0) return false;
                chars[c]--;
            }
            return true;
        }
    }
}
