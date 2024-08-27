using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MinimumAbsoluteDifferenceInBSTProblem
    {
        public int GetMinimumDifference(TreeNode? root)
        {
            int minDiff = 100001;
            int prevVal = -100001;
            Stack<TreeNode> visited = [];
            while (root != null || visited.Count > 0)
            {
                while (root != null)
                {
                    visited.Push(root);
                    root = root.left;
                }
                root = visited.Pop();
                if (prevVal >= 0) minDiff = Math.Min(minDiff, root.val - prevVal);
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
