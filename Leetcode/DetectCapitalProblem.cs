using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class DetectCapitalProblem
    {
        public static bool DetectCapitalUse(string word)
        {
            int capitalCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] < 97) capitalCount++;
            }
            return (word[0] < 97 && capitalCount == 1)
                   || capitalCount == word.Length
                   || capitalCount == 0;
        }
    }
}
