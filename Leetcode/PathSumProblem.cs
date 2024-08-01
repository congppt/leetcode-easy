using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PathSumProblem
    {
        public static bool HasPathSum(TreeNode? root, int targetSum)
        {
            return HasPathSumRecursive(root, targetSum);
        }
        static bool HasPathSumRecursive(TreeNode? root, int targetSum)
        {
            if (root == null) return false;
            var leftSum = targetSum - root.val;
            if (leftSum == 0 && root.left == null && root.right == null) return true;
            return HasPathSum(root.left, leftSum) || HasPathSum(root.right, leftSum);
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
