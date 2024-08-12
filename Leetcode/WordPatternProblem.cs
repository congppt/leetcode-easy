using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class WordPatternProblem
    {
        public static bool WordPattern(string pattern, string s)
        {
            var words = s.Split(' ');
            if (pattern.Length != words.Length) return false;
            string[] map = new string[26];
            HashSet<string> used = [];
            for(int i = 0; i < pattern.Length; i++)
            {
                if (map[pattern[i] - 'a'] == null)
                {
                    if (used.Contains(words[i])) return false;
                    map[pattern[i] - 'a'] = words[i];
                    used.Add(words[i]);
                }    
                else if (map[pattern[i] - 'a'] != words[i]) return false;
            }
            return true;
        }
    }
}
