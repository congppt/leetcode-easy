using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ValidPalindromeIIProblem
    {
        public bool ValidPalindrome(string s)
        {
            int start = 0, end = s.Length - 1;
            while (start < end)
            {
                if (s[start] != s[end])
                    return IsPalindrome(start, end - 1, s) 
                        || IsPalindrome(start + 1, end, s);
                start++;
                end--;
            }
            return true;
        }
        bool IsPalindrome(int start, int end, string s)
        {

            while (start < end)
                if (s[start++] != s[end--]) return false;
            return true;
        }
    }
}