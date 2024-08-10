using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class BinaryTreePathsProblem
    {
        public static IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> result = [];
            PathsRecursive(root, string.Empty, ref result);
            return result;
        }
        static void PathsRecursive(TreeNode root, string current, ref List<string> result)
        {
            var newCurrent = current + $"{root.val}";
            if (root.left == null && root.right == null)
                result.Add(newCurrent);
            else newCurrent += "->";
            if (root.left != null)
                PathsRecursive(root.left, newCurrent, ref result);
            if (root.right != null)
                PathsRecursive(root.right, newCurrent, ref result);
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
