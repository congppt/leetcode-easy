using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SumOfLeftLeavesProblem
    {
        public int SumOfLeftLeaves(TreeNode? root)
        {
            return SumOfLeftLeavesRecursive(root, false);
        }
        int SumOfLeftLeavesRecursive(TreeNode? root, bool isLeftNode)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null && isLeftNode) return root.val;
            return SumOfLeftLeavesRecursive(root.left, true) + SumOfLeftLeavesRecursive(root.right, false);
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
