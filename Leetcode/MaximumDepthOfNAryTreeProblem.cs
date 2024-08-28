using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MaximumDepthOfNAryTreeProblem
    {
        public int MaxDepth(Node? root)
        {
            if (root == null) return 0;
            if (root.children == null) return 1;
            var maxChildDepth = 0;
            foreach ( var child in root.children )
            {
                var childDepth = MaxDepth(child);
                if (childDepth > maxChildDepth) maxChildDepth = childDepth;
            }
            return 1 + maxChildDepth;
        }
        public class Node
        {
            public int val;
            public IList<Node>? children;

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
