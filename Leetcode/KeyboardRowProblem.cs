using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class KeyboardRowProblem
    {
        public string[] FindWords(string[] words)
        {
            HashSet<char> row1 = ['q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'];
            HashSet<char> row2 = ['a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l'];
            HashSet<char> row3 = ['z', 'x', 'c', 'v', 'b', 'n', 'm'];
            List<string> results = [];
            bool isAppropriate = true;
            for(int i = 0; i < words.Length; i++)
            {              
                isAppropriate = IsAppropriate(words[i], row1)
                                || IsAppropriate(words[i], row2)
                                || IsAppropriate(words[i], row3);                             
                if (isAppropriate) results.Add(words[i]);
                isAppropriate = false;
            }
            return [.. results];
        }
        bool IsAppropriate(string words, HashSet<char> row)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (!row.Contains(words[i]) && !row.Contains((char)(words[i] + 32))) return false;
            }
            return true;
        }
    }
}
