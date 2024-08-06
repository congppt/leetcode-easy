using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ReverseLinkedListProblem
    {
        public static ListNode? ReverseList(ListNode? head)
        {
            if (head == null) return null;
            ListNode? prev = null, next = null;
            ListNode? curr = head;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }
        static ListNode? ReverseListStack(ListNode? head)
        {
            if (head == null) return null;
            Stack<int> nodeVals = [];
            while (head != null)
            {
                nodeVals.Push(head.val);
                head = head.next;
            }
            var newHead = new ListNode();
            var iter = newHead;
            while (nodeVals.Count > 0)
            {
                iter.next = new ListNode(nodeVals.Pop());
                iter = iter.next;
            }
            return newHead.next;
        }
        public class ListNode
        {
            public int val;
            public ListNode? next;
            public ListNode(int val = 0, ListNode? next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
