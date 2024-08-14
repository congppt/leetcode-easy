using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class GuessNumberHigherOrLowerProblem
    {
        public int GuessNumber(int n)
        {
            var low = 1;
            var high = n;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                var guessResult = guess(mid);
                switch (guessResult)
                {
                    case 0:
                        return mid;
                    case 1:
                        low = mid + 1;
                        break;
                    case -1:
                        high = mid - 1;
                        break;
                }
            }
            throw new Exception();
        }
        //mock leetcode guess api
        int guess(int num)
        {
            return -1;
        }
    }
}
