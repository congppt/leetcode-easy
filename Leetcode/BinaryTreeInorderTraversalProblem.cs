namespace Leetcode
{
    public class BinaryTreeInorderTraversalProblem
    {
        public IList<int> InorderTraversal(TreeNode? root)
        {
            if (root == null) return [];
            List<int> result = [];
            //InorderTraversalRecursive(root, ref result);
            Stack<TreeNode> tree = [];
            while (root != null || tree.Count > 0)
            {
                while (root != null)
                {
                    tree.Push(root);
                    root = root.left;
                }
                root = tree.Pop();
                result.Add(root.val);
                root = root.right;
            }
            return result;
        }
        public void InorderTraversalRecursive(TreeNode? root, ref List<int> visited)
        {
            if (root == null) return;
            if (root.left != null) InorderTraversalRecursive(root.left, ref visited);
            visited.Add(root.val);
            if (root.right != null) InorderTraversalRecursive(root.right, ref visited);
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
