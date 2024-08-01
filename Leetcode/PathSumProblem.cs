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
            if (root == null) return false;
            Stack<TreeNode> parents = [];
            while (root != null ||  parents.Count > 0)
            {
                if (root != null)
                {
                    targetSum -= root.val;
                    if (targetSum == 0 && root.left == null && root.right == null) 
                        return true;
                    parents.Push(root);
                    root = root.left;
                }
                else
                {
                    root = parents.Pop();
                    if (root.right == null) targetSum += root.val;
                    root = root.right;
                }
            }
            return false;
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
