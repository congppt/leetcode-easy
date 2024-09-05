using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SecondMinimumNodeInABinaryTreeProblem
    {
        public int FindSecondMinimumValue(TreeNode root)
        {
            var min = root.val;
            var secondMin = int.MaxValue;
            bool hasSecondMin = false;
            Queue<TreeNode> bfs = [];
            bfs.Enqueue(root);
            while (bfs.Count > 0){
                var node = bfs.Dequeue();
                if (node.val > min && node.val <= secondMin)
                {
                    secondMin = node.val;
                    hasSecondMin = true;
                }   
                if (node.left != null)
                {
                    bfs.Enqueue(node.left);
                    bfs.Enqueue(node.right!);
                }
            }
            return hasSecondMin ? secondMin : -1;
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