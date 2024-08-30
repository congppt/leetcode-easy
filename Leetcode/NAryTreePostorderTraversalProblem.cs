using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class NAryTreePostorderTraversalProblem
    {       
        List<int> nodes = [];
        public IList<int> Postorder(Node? root)
        {
            if (root == null) return nodes;
            Stack<Node> visited = [];
            while (root != null || visited.Count > 0){
                if (root != null){
                    nodes.Insert(0, root.val);
                    for (int i = 0; i < root.children.Count; i++)
                        visited.Push(root.children[i]);
                    root = null;
                } else root = visited.Pop();
            }
            return nodes;
        }
        public IList<int> PostorderRecursive(Node root){
            if (root == null) return nodes;
            for (int i = 0; i < root.children.Count; i++)
                PostorderRecursive(root.children[i]);
            nodes.Add(root.val);
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