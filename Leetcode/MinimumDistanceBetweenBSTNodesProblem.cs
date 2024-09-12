using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MinimumDistanceBetweenBSTNodesProblem
    {
        private int minimalDiff = int.MaxValue;
        private int prevValue = -1;
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
                if (prevVal >= 0) minDiff = Math.Min(minDiff, root.val - prevVal);
                prevVal = root.val;
                root = root.right;
            }
            return minDiff;
        }
        void MinDiffInBSTRecursive(TreeNode? root){
            if (root == null) return;
            if (root.left != null) MinDiffInBSTRecursive(root.left);
            if (prevValue >= 0) minimalDiff = Math.Min(minimalDiff, root.val - prevValue);
            prevValue = root.val;
            if (root.right != null) MinDiffInBSTRecursive(root.right);
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