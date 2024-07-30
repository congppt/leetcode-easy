using Leetcode;
var treeNode1 = new SameTreeProblem.TreeNode(1, new SameTreeProblem.TreeNode(2), new SameTreeProblem.TreeNode(3));
var treeNode2 = new SameTreeProblem.TreeNode(1, new SameTreeProblem.TreeNode(2), new SameTreeProblem.TreeNode(3));
Console.WriteLine(SameTreeProblem.IsSameTree(treeNode1, treeNode2));
