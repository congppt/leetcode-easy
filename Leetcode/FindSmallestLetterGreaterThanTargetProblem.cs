using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class FindSmallestLetterGreaterThanTargetProblem
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int start = 0, end = letters.Length - 1, mid = 0;
            while (start <= end){
                mid = start + (end - start) / 2;
                if (letters[mid] == target) break;
                if (letters[mid] < target) start = mid + 1;
                else end = mid - 1;
            }
            for (int i = mid; i < letters.Length; i++)
                if (letters[i] > target) return letters[i];
            return letters[0];
        }
    }
}