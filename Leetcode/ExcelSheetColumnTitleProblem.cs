using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ExcelSheetColumnTitleProblem
    {
        public string ConvertToTitle(int columnNumber)
        {
            var title = string.Empty;
            int i = 0;
            while (columnNumber != 0)
            {
                var spare = columnNumber % 26;
                if (spare == 0) {
                    title = title.Insert(0, "Z");
                    columnNumber = (columnNumber - 26) / 26;
                }
                else
                {
                    title = title.Insert(0, ((char)(spare + 64)).ToString());
                    columnNumber = (columnNumber - spare) / 26;
                }
                i++;
            }
            return title;
        }

    }
}
