using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class AddStringProblem
    {
        public string AddStrings(string num1, string num2)
        {
            var left = 0;
            var total = string.Empty;
            int i = num1.Length - 1, j = num2.Length - 1;
            while (i >= 0 || j >= 0 || left != 0)
            {
                var sum = 0;
                if (i >= 0) sum += num1[i--] - '0';
                if (j >= 0) sum += num2[j--] - '0';
                sum += left;
                var digit = (char)(sum + '0');
                if (sum >= 10)
                {
                    digit = (char)(sum % 10 + '0');
                    left = 1;
                }
                else left = 0;
                total = digit + total;
            }
            return total;
        }
    }
}
