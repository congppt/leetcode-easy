namespace Leetcode
{
    public class SearchInsertPositionProblem
    {
        public static int SearchInsert(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            while (left <= right)
            {
                var mid = left + (right - left)/2;
                if (target == nums[mid]) return mid;
                if (target > nums[mid])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return left;
        }
    }
}
