using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ConvertSortedArrayToBinarySearchTreeProblem
    {
        public static TreeNode? SortedArrayToBST(int[] nums)
        {
            return ConvertToBST(0, nums.Length - 1, nums);
        }
        public static TreeNode? ConvertToBST(int start, int end, int[] nums)
        {
            if (start > end) return null;
            var mid = (start + end) / 2;
            var root = new TreeNode(nums[mid]);
            root.left = ConvertToBST(start, mid - 1, nums);
            root.right = ConvertToBST(mid + 1, end, nums);
            return root;
        }
        public class TreeNode
        {
            public int val;
            public TreeNode? left;
            public TreeNode? right;
            public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
