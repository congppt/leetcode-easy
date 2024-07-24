

namespace Leetcode
{
    public class TwoSumProblem
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var value = target - nums[i];
                if (dict.TryGetValue(value, out var first)) 
                    return [first, i];
                if (!dict.TryGetValue(nums[i], out var index))
                    dict.Add(nums[i], i);                
            }
            throw new ArgumentException("Not found");
        }
    }
}
