using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MinimumDistanceBetweenBSTNodesProblem
    {
        public int MinDiffInBST(TreeNode? root)
        {
            Stack<TreeNode> stack = [];
            int minDiff = int.MaxValue;
            int prevVal = -1;
            while (root != null || stack.Count > 0){
                while (root != null){
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                if (prevVal > 0) minDiff = Math.Min(minDiff, root.val - prevVal);
                prevVal = root.val;
                root = root.right;
            }
            return minDiff;
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