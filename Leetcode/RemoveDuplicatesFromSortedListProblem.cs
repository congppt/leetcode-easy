using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RemoveDuplicatesFromSortedListProblem
    {
        public static ListNode? DeleteDuplicates(ListNode? head)
        {
            if (head == null) return null;
            var root = new ListNode(head.val);
            ListNode lastNode = root;
            while (head.next != null)
            {
                head = head.next;
                if (lastNode.val == head.val) continue;
                lastNode.next = new ListNode(head.val);
                lastNode = lastNode.next;
            }
            return root;
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
