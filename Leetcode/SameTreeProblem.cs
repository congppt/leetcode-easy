using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class SameTreeProblem
    {
        public static bool IsSameTree(TreeNode? p, TreeNode? q)
        {
            //if (p == null && q == null) return true;
            //Stack<TreeNode> tree1 = [];
            //Stack<TreeNode> tree2 = [];
            //while (p != null || q != null || (tree1.Count > 0 && tree2.Count > 0))
            //{
            //    if (p != null && (q == null || q.val != p.val)) return false;
            //    if (q != null && p == null) return false;
            //    if (p != null)
            //    {
            //        tree1.Push(p);
            //        p = p.left;
            //    }
            //    else p = tree1.Pop().right;
            //    if (q != null)
            //    {
            //        tree2.Push(q);
            //        q = q.left;
            //    } 
            //    else q = tree2.Pop().right;
            //}
            return IsSameNode(p, q);
        }
        static bool IsSameNode(TreeNode? p, TreeNode? q)
        {
            if (p == null && q == null) return true;
            if (p != null && (q == null || q.val != p.val)) return false;
            if (q != null && p == null) return false;
            var isLeftSame = IsSameNode(p.left, q.left);
            return isLeftSame && IsSameNode(p.right, q.right);
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
