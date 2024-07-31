using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MinimumDepthOfBinaryTreeProblem
    {
        public static int MinDepth(TreeNode? root)
        {
            if (root == null) return 0;
            if (root.left == null) return 1 + MinDepth(root.right);
            if (root.right == null) return 1 + MinDepth(root.left);
            return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
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
