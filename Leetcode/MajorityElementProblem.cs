using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MajorityElementProblem
    {
        public static int MajorityElement(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            //boyes-moore vote
            var mostAppear = nums[0];
            var votes = 1;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != mostAppear) votes--;
                else votes++;
                if (votes == 0)
                {
                    mostAppear = nums[i];
                    votes = 1;
                }
            }
            return mostAppear;
        }
    }
}
