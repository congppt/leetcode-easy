using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class NumberOfSegmentsInAStringProblem
    {
        public int CountSegments(string s)
        {
            var count = 0;
            bool isFirst = true;
            for (int i = 0; i < s.Length; i++)
            {
                bool isSpace = s[i] == ' ';
                if (!isSpace && isFirst)
                    count++;
                isFirst = isSpace;
            }
            return count;
        }
    }
}
