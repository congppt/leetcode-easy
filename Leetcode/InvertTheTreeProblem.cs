using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class InvertTheTreeProblem
    {
        public static TreeNode? InvertTree(TreeNode? root)
        {
            if (root == null) return null;
            (root.right, root.left) = (root.left, root.right);
            InvertTree(root.left);
            InvertTree(root.right);
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
