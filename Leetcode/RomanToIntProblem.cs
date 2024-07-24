using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RomanToIntProblem
    {

        public static int RomanToInt(string s)
        {
            Dictionary<char, int> roman = new()
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };
            int prevVal = 0;
            var result = 0;
            for(int i = s.Length - 1; i >= 0; i--)
            {
                if (prevVal > roman[s[i]])
                    result -= roman[s[i]];
                else
                    result += roman[s[i]];
                prevVal = roman[s[i]];
            }
            return result;
        }
    }
}
