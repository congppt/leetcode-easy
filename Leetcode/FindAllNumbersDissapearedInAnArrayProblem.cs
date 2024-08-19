using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class FindAllNumbersDissapearedInAnArrayProblem
    {
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            //mark all 1st appearance of numbers by reverse value at index 'number - 1'
            //if number is missing => the value of index 'number - 1' will not be reverse
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0) nums[index] = -nums[index];
            }
            List<int> result = [];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) result.Add(i + 1);
            }
            return result;

        }
    }
}
