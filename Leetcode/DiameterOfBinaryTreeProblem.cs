using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class DiameterOfBinaryTreeProblem
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            var diameter = 0;
            GetHeight(root, ref diameter);
            return diameter;
        }
        int GetHeight(TreeNode? root, ref int maxDiameter)
        {
            if (root == null) return 0;
            var leftHeight = GetHeight(root.left, ref maxDiameter);
            var rightHeight = GetHeight(root.right, ref maxDiameter);
            if (leftHeight + rightHeight > maxDiameter) maxDiameter = leftHeight + rightHeight;
            return 1 + Math.Max(leftHeight, rightHeight);
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
