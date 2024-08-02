using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ValidPalindromeProblem
    {
        public static bool IsPalindrome(string s)
        {
            var cleanedString = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();
            if (cleanedString.Length == 0) return true;
            for (int i = 0; i < cleanedString.Length / 2 + 1; i++)
            {
                if (cleanedString[i] != cleanedString[^(i + 1)]) return false;
            }
            return true;
        }
    }
}
