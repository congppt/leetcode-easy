using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class TwoSumIVInputIsABSTProblem
    {
        public bool FindTarget(TreeNode? root, int k)
        {
            var stack = new Stack<TreeNode>();
            var set = new HashSet<int>();
            while (root != null || stack.Count > 0)
            {
                if (root != null)
                {
                    if (set.Contains(k - root.val)) return true;
                    set.Add(root.val);
                    stack.Push(root);
                    root = root.left;
                }
                else root = stack.Pop().right;
            }
            return false;
        }
        public bool FindTargetRecursive(TreeNode? root, int k, ref HashSet<int> set)
        {
            if (root == null) return false;
            if (set.Contains(k - root.val)) return true;
            set.Add(root.val);
            return FindTargetRecursive(root.left, k, ref set)
                || FindTargetRecursive(root.right, k, ref set);
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