using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ExcelSheetColumnNumberProblem
    {
        public static int TitleToNumber(string columnTitle)
        {
            var num = 0;
            for(int i = 0; i < columnTitle.Length; i++)
            {
                num *= 26;
                num += columnTitle[i] - 64;
            }
            return num;
        }
    }
}
