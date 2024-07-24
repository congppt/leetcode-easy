using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class FindTheIndexOfTheFirstOccurenceInAStringProblem
    {
        public static int StrStr(string haystack, string needle)
        {
            if (needle.Length > haystack.Length) return -1;
            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if (haystack[i] != needle[0]) continue;
                if (needle.Length == 1) return i;
                var j = 1;
                while (j < needle.Length && haystack[i + j] == needle[j])
                    j++;
                if (j == needle.Length) return i;
            }
            return -1;
        }
    }
}
