using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class AverageOfLevelsInBinaryTreeProblem
    {

        public IList<double> AverageOfLevels(TreeNode? root)
        {
            List<double> avgs = [];
            if (root == null) return avgs;
            var sum = 0.0;
            Queue<TreeNode> queue = [];
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var nodeCount = queue.Count;
                for (int i = 0; i < nodeCount; i++)
                {
                    var node = queue.Dequeue();
                    sum += node.val;
                    if (node.left != null)                   
                        queue.Enqueue(node.left);                   
                    if (node.right != null)                    
                        queue.Enqueue(node.right);                   
                }
                avgs.Add(sum / nodeCount);
                sum = 0;
            }
            return avgs;
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