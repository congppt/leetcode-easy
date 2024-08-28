using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ReverseWordsInAStringIIIProblem
    {
        public string ReverseWords(string s)
        {
            var words = s.Split(' ');
             var builder = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                var wordArr = words[i].ToCharArray();
                var start = 0;
                var end = wordArr.Length - 1;
                while (start < end)
                {
                    wordArr[start] = words[i][end];
                    wordArr[end--] = words[i][start++];
                }
                builder.Append(wordArr);
                if (i < words.Length - 1) builder.Append(" ");
            }
            return builder.ToString();
        }
    }
}
