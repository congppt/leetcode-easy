using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class CountCompleteTreeNodesProblem
    {
        public static int CountNodes(TreeNode? root)
        {
            if (root == null) return 0;
            return 1+ CountNodes(root.left) + CountNodes(root.right);
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
