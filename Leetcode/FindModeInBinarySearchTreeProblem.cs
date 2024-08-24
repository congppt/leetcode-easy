using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class FindModeInBinarySearchTreeProblem
    {
        public int[] FindMode(TreeNode? root)
        {
            var maxCount = 0;
            List<int> results = [];
            int currentCount = 0;
            int currentVal = int.MinValue;
            Stack<TreeNode> stack = [];
            //find mode of subtree
            while (root != null || stack.Count > 0)
            {
                //check from left most node value
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                //use Inorder traverse because next val == currentVal only when nextVal is parent or nextVal is right child of currentVal
                //=> if next val != currentVal => currentVal no longer appear in tree.
                if (root.val != currentVal)
                {
                    currentVal = root.val;
                    currentCount = 0;
                }
                currentCount++;
                if (currentCount > maxCount)
                {
                    results.Clear();
                    results.Add(root.val);
                    maxCount = currentCount;
                }
                else if (currentCount == maxCount) results.Add(root.val);
                root = root.right;
            }
            return [.. results];
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
