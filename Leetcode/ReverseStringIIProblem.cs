using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ReverseStringIIProblem
    {
        public static string ReverseStr(string s, int k)
        {
            var sArray = s.ToCharArray();
            for (int i = 0; i < s.Length; i += 2 * k)
            {
                var start = i;
                var end = Math.Min(start + k - 1, s.Length - 1);
                while (start < end)
                {
                    sArray[start] = s[end];
                    sArray[end--] = s[start++];
                }
            }
            return new string(sArray);
        }
    }
}
