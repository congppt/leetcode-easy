using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ImageSmootherProblem
    {
        public static int[][] ImageSmoother(int[][] img)
        {
            int[][] newImg = new int[img.Length][];
            for (int i = 0; i < img.Length; i++){
                newImg[i] = new int[img[i].Length];
                for (int j = 0; j < img[i].Length; j++)
                {
                    var count = 1;
                    var sum = img[i][j];

                    bool hasLeft = i > 0, hasRight = i < img.Length - 1;
                    sum += hasLeft ? img[i - 1][j] : 0;
                    count += hasLeft ? 1 : 0;

                    sum += hasRight ? img[i + 1][j] : 0;
                    count += hasRight ? 1 : 0;

                    bool hasUp = j > 0, hasDown = j < img[i].Length - 1;
                    sum += hasUp ? img[i][j - 1] : 0;
                    count += hasUp ? 1 : 0;

                    sum += hasDown ? img[i][j + 1] : 0;
                    count += hasDown ? 1 : 0;

                    bool hasUpLeft = hasLeft && hasUp, hasUpRight = hasUp && hasRight;
                    sum += hasUpLeft ? img[i - 1][j - 1] : 0;
                    count += hasUpLeft ? 1 : 0;
                    
                    sum += hasUpRight ? img[i + 1][j - 1] : 0;
                    count += hasUpRight ? 1 : 0;

                    bool hasDownLeft = hasLeft && hasDown, hasDownRight = hasDown && hasRight;
                    sum += hasDownLeft ? img[i - 1][j + 1] : 0;
                    count += hasDownLeft ? 1 : 0;

                    sum += hasDownRight ? img[i + 1][j + 1] : 0;
                    count += hasDownRight ? 1 : 0;

                    newImg[i][j] = sum / count;
                }
            }
            return newImg;
        }
    }
}