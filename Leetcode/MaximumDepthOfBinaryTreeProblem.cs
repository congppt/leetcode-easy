namespace Leetcode
{
    public class MaximumDepthOfBinaryTreeProblem
    {
        public static int MaxDepth(TreeNode? root)
        {
            if (root == null) return 0;
            var maxDepth = 0;
            var currentDepth = 0;
            Dictionary<TreeNode, int> depthDict = [];
            Stack<TreeNode> oldNodes = [];
            while (root != null || oldNodes.Count > 0)
            {
                if (root != null)
                {
                    currentDepth++;
                    oldNodes.Push(root);
                    depthDict.Add(root, currentDepth);
                    root = root.left;
                }
                else
                {
                    if (currentDepth > maxDepth) maxDepth = currentDepth;
                    root = oldNodes.Pop();
                    currentDepth = depthDict[root];
                    root = root.right;
                }
            }
            return maxDepth;
        }
        static int MaxDepthRecursive(TreeNode? root)
        {
            if (root == null) return 0;
            return 1 + Math.Max(MaxDepthRecursive(root.left), MaxDepthRecursive(root.right));
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
