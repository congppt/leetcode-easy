using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class BinaryPostorderTraversalProblem
    {
        public static IList<int> PostorderTraversal(TreeNode? root)
        {
            if (root == null) return [];
            Stack<TreeNode> stack = [];
            List<int> result = [];
            stack.Push(root);
            while (stack.Count > 0)
            {
                root = stack.Pop();
                result.Insert(0, root.val);
                if (root.left != null) stack.Push(root.left);
                if (root.right != null) stack.Push(root.right);
            }
            return result;
        }
        static IList<int> PostorderTraversalRecursive(TreeNode? root, ref List<int> result)
        {
            if (root == null) return result;
            PostorderTraversalRecursive(root.left, ref result);
            PostorderTraversalRecursive(root.right, ref result);
            result.Add(root.val);
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
