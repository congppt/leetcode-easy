using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SymmetricTreeProblem
    {
        public static bool IsSymmetric(TreeNode root)
        {
            if (root.left == null && root.right == null) return true;
            Stack<TreeNode> leftBranch = [];
            Stack<TreeNode> rightBranch = [];
            var left = root.left;
            var right = root.right;
            while (left != null || right != null || leftBranch.Count > 0)
            {
                if (left != null && (right == null || left.val != right.val)) return false;
                if (right != null && left == null) return false;
                if (left != null)
                {
                    leftBranch.Push(left);
                    left = left.left;
                }
                else left = leftBranch.Pop().right;
                if (right != null)
                {
                    rightBranch.Push(right);
                    right = right.right;
                }
                else right = rightBranch.Pop().left;
            }
            return true;
        }
        static bool IsSymmetricRecursive(TreeNode? left, TreeNode? right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null || (left.val != right.val)) return false;
            return IsSymmetricRecursive(left.left, right.right) && IsSymmetricRecursive(left.right, right.left);
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
