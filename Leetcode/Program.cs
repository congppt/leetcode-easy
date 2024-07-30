using Leetcode;
var tree = new MaximumDepthOfBinaryTreeProblem.TreeNode(3, 
            new MaximumDepthOfBinaryTreeProblem.TreeNode(9), 
            new MaximumDepthOfBinaryTreeProblem.TreeNode(20, 
                    new MaximumDepthOfBinaryTreeProblem.TreeNode(15), 
                    new MaximumDepthOfBinaryTreeProblem.TreeNode(7)));
Console.WriteLine(MaximumDepthOfBinaryTreeProblem.MaxDepth(tree));
