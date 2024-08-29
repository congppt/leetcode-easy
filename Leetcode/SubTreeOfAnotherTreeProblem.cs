using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SubTreeOfAnotherTreeProblem
    {
        public bool IsSubtree(TreeNode? root, TreeNode? subRoot) {
            if (root == null)
                return false;
            return IsIdentical(root, subRoot) || IsSubtree(root?.left, subRoot) || IsSubtree(root?.right, subRoot);
        }
        bool IsIdentical(TreeNode? node1, TreeNode? node2) {
            if (node1 == null != (node2 == null))
                return false;
            if (node1 == node2) return true;
            return node1!.val == node2!.val && IsIdentical(node1.left, node2.left) && IsIdentical(node1.right, node2.right);
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