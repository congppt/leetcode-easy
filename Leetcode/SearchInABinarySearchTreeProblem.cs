using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SearchInABinarySearchTreeProblem
    {
        public TreeNode? SearchBST(TreeNode? root, int val)
        {
            while (root != null){
                if (root.val == val) return root;
                if (root.val > val) root = root.left;
                else root = root.right;
            }
            return null;
        }
        public TreeNode? SearchBSTRecursive(TreeNode? root, int val)
        {
            if (root == null) return null;
            if (root.val > val) return SearchBST(root.left, val);
            if (root.val < val) return SearchBST(root.right, val);
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