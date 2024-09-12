using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ToeplitzMatrixProblem
    {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            for (int j = 1; j < matrix.Length; j++){
                for (int i = 1; i < matrix[j].Length; i++){
                    if (matrix[j - 1][i - 1] != matrix[j][i])
                        return false;
                }
            }
            return true;
        }
    }
}