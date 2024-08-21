using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class IslandPerimeterProblem
    {
        public int IslandPerimeter(int[][] grid)
        {
            var perimeter = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0) continue;
                    var border = 4;
                    if (j >= 1 && grid[i][j - 1] == 1) border -= 2;
                    if (i >= 1 && grid[i - 1][j] == 1) border -= 2;
                    perimeter += border;
                }
            }
            return perimeter;
        }
    }
}
