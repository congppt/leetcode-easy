using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class NAryTreePreOrderTraversalProblem
    {
        public List<int> nodes = [];
        public IList<int> Preorder(Node? root)
        {
            if (root == null) return nodes;
            Stack<Node> visited = [];
            while (root != null || visited.Count > 0){
                if (root != null){
                    nodes.Add(root.val);
                    for (int i = root.children.Count - 1; i >= 0; i--){
                        visited.Push(root.children[i]);
                    }
                    root = null;
                } else root = visited.Pop();
            }
            return nodes;
        }
        public IList<int> PreorderRecursive(Node? root)
        {
            if (root == null) return nodes;
            nodes.Add(root.val);
            for (int i = 0; i < root.children.Count; i++)
            {
                PreorderRecursive(root.children[i]);
            }
            return nodes;
        }
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }
    }
}