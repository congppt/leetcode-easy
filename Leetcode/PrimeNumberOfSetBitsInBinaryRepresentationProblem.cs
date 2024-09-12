using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PrimeNumberOfSetBitsInBinaryRepresentationProblem
    {
        public int CountPrimeSetBits(int left, int right)
        {
            HashSet<int> primes = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31];
            int count = 0;
            int CountSetBits(int num){
                var count = 0;
                while (num > 0){
                    count += num & 1;
                    num >>= 1;
                }
                return count;
            }
            while (left <= right){
                if (primes.Contains(CountSetBits(left++))) count++;
            }
            return count;
        }
    }
}