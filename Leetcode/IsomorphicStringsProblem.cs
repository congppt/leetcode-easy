using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class IsomorphicStringsProblem
    {
        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;
            const int max = 256;
            bool[] visited = new bool[max];
            int[] map = new int[max];
            for (int i = 0; i < map.Length; i++) map[i] = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (map[s[i]] == -1)
                {
                    if (visited[t[i]])
                        return false;
                    visited[t[i]] = true;
                    map[s[i]] = t[i];
                } else if (map[s[i]] != t[i]) 
                    return false;
            }
            return true;
        }
    }
}
