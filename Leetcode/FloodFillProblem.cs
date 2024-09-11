using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class FloodFillProblem
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            if (image[sr][sc] != color){
                var oldColor = image[sr][sc];
                image[sr][sc] = color;
                bool hasLeft = sr > 0 && image[sr - 1][sc] == oldColor, hasRight = sr < image.Length - 1 && image[sr + 1][sc] == oldColor;
                bool hasUp = sc > 0 && image[sr][sc - 1] == oldColor, hasDown = sc < image[sr].Length - 1 && image[sr][sc + 1] == oldColor;
                if (hasLeft) FloodFill(image, sr - 1, sc, color);
                if (hasRight) FloodFill(image, sr + 1, sc, color);
                if (hasUp) FloodFill(image, sr, sc - 1, color);
                if (hasDown) FloodFill(image, sr, sc + 1, color);
            }
            return image;
        }
    }
}