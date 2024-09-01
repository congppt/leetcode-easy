using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class CanPlaceFlowersProblem
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            //int prevTreeIndex = -2;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] != 0) continue;
                bool prevEmpty = i == 0 || flowerbed[i - 1] == 0;
                bool nextEmpty = i == flowerbed.Length - 1 || flowerbed[i + 1] == 0;
                if (prevEmpty && nextEmpty){
                    n--;
                    flowerbed[i] = 1;
                    //next position will not be available so skip check
                    i++;
                }
                //another approach
                // if (flowerbed[i] == 1){
                //     if (prevTreeIndex == i - 1) n++;
                //     prevTreeIndex = i;
                // } 
                // else {
                //     if (prevTreeIndex == i - 1)
                //      continue;
                //     flowerbed[i] = 1;
                //     prevTreeIndex = i;
                //     n--;
                // }
            } 
            return n <= 0;
        }
    }
}