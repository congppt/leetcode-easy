using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ReshapeTheMatrixProblem
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            if (mat.Length * mat[0].Length != r * c ) return mat;
            int[][] matrix = new int[r][];
            for (int x = 0; x < r; x++)
                matrix[x] = new int[c];
            int i = 0;
            int j = 0;
            for (int a = 0; a < mat.Length; a++)
            {
                for (int b = 0; b < mat[a].Length; b++)
                {
                    matrix[i][j++] = mat[a][b];
                    if (j == c)
                    {
                        i++;
                        j = 0;
                    }

                }
            }
            return matrix;
        }
    }
}