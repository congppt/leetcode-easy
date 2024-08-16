using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class FizzBuzzProblem
    {
        public IList<string> FizzBuzz(int n)
        {
            List<string> result = [];
            for (int i = 1; i <= n; i++)
            {
                var val = string.Empty;
                if (i % 3 == 0) val += "Fizz";
                if (i % 5 == 0) val += "Buzz";
                if (val.Length == 0) val = i.ToString();
                result.Add(val);
            }
            return result;
        }
    }
}
