using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class IntersectionOfTwoLinkedListProblem
    {
        public ListNode? GetIntersectionNode(ListNode? headA, ListNode? headB)
        {
            //O(m+n) time complexity O(1) space complexity 
            //if (headA == null || headB == null) return null;
            //var node1 = headA;
            //var node2 = headB;
            //while (node1 != node2)
            //{
            //    if (node1 != null) node1 = node1.next;
            //    else node1 = headB;
            //    if (node2 != null) node2 = node2.next;
            //    else node2 = headA;
            //}
            //return node1;
            //O(m+n) time complexity O(m) space complexity
            if (headA == null || headB == null) return null;
            HashSet<ListNode> headANodes = [];
            while (headA != null)
            {
                headANodes.Add(headA);
                headA = headA.next;
            }
            while (headB != null)
            {
                if (headANodes.Contains(headB)) return headB;
                headB = headB.next;
            }
            return null;
        }
        public class ListNode
        {
            public int val;
            public ListNode? next;
            public ListNode(int x) { val = x; }
        }
    }
}
