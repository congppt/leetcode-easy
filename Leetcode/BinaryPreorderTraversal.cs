using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class BinaryPreorderTraversal
    {
        public static IList<int> PreorderTraversal(TreeNode? root)
        {
            if (root == null) return [];
            List<int> result = [];
            Stack<TreeNode> visited = [];
            while (root != null || visited.Count > 0)
            {
                if (root != null)
                {
                    result.Add(root.val);
                    visited.Push(root);
                    root = root.left;
                } else root = visited.Pop().right;
            }
            return result;
        }
        static IList<int> PreorderTraversalRecursive(TreeNode? root, ref List<int> result)
        {
            if (root == null) return result;
            result.Add(root.val);
            PreorderTraversalRecursive(root.left, ref result);
            PreorderTraversalRecursive(root.right, ref result);
            return result;
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
