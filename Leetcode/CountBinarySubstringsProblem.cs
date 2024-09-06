using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class CountBinarySubstringsProblem
    {
        public static int CountBinarySubstrings(string s) {
            int streak = 1;
            int prevStreak = 0;
            int count = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1]) streak++;
                else {
                    prevStreak = streak;
                    streak = 1;
                }
                if (prevStreak >= streak) count++;
            }
            return count;
        }
    }
}