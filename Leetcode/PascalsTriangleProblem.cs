using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PascalsTriangleProblem
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            int[][] result = new int[numRows][];
            result[0] = [1];
            for (int i = 1; i < numRows; i++)
            {
                int[] row = new int[i + 1];
                row[0] = 1;
                row[^1] = 1;
                for (int j = 1; j < i; j++)
                    row[j] = result[i - 1][j - 1] + result[i - 1][j];
                result[i] = row;
            }
            return result;
        }
    }
}
