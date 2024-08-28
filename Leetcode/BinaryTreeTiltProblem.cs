using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode.obj
{
    public class BinaryTreeTiltProblem
    {
        public int FindTilt(TreeNode? root)
        {
            if (root == null) return 0;
            var tilt = 0;
            Sum(root, ref tilt);
            return tilt;
        }
        int Sum(TreeNode? root, ref int tilt){
            if (root == null) return 0;
            var left = Sum(root.left, ref tilt);
            var right = Sum(root.right, ref tilt);
            tilt += Math.Abs(left- right);
            return root.val + left + right;
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