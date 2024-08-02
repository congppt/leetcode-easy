using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PascalsTriangleIIProblem
    {
        public static IList<int> GetRow(int rowIndex)
        {
            int[] row = new int[rowIndex + 1];
            int mid, prev, temp;
            for (var i = 0; i < row.Length; i++)
            {
                row[i] = 1;
                mid = i / 2 + 1;
                prev = 1;
                for (var j = 1; j < mid; j++)
                {
                    temp = row[j];
                    row[j] = row[i - j] = prev + row[j];
                    prev = temp;
                }
            }
            return row;
        }
    }
}
