using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LongestPalindromeProblem
    {
        public int LongestPalindrome(string s)
        {
            int[] appearances = new int[58];
            foreach (char c in s) appearances[c - 'A']++;
            var maxLength = 0;
            int odd = 0;
            for (int i = 0; i < appearances.Length; i++)
            {
                if (appearances[i] == 0) continue;
                if (appearances[i] % 2 == 0)
                    maxLength += appearances[i];
                else
                {
                    odd = 1;
                    maxLength += appearances[i] - 1;
                }
            }
            maxLength += odd;
            return maxLength;
        }
    }
}
