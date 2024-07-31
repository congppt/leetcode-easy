using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class BalancedBinaryTreeProblem
    {
        public static bool IsBalanced(TreeNode? root)
        {
            if (root == null) return true;
            var leftMaxDepth = FindMaxDepth(root.left);
            var rightMaxDepth = FindMaxDepth(root.right);
            if (Math.Abs(leftMaxDepth - rightMaxDepth) > 1) return false; 
            return IsBalanced(root.left) && IsBalanced(root.right);
            
        }
        static int FindMaxDepth(TreeNode? root)
        {
            if (root == null) return 0;
            return 1 + Math.Max(FindMaxDepth(root.left), FindMaxDepth(root.right));
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
