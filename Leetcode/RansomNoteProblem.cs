using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RansomNoteProblem
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length) return false;
            int[] chars = new int[26];
            foreach (var c in magazine) chars[c - 'a']++;
            foreach (char c in ransomNote)
            {
                if (chars[c - 'a'] <= 0) return false;
                chars[c - 'a']--;
            }
            return true;
        }
    }
}
