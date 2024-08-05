using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RemoveLinkedListElementsProblem
    {
        public ListNode? RemoveElements(ListNode? head, int val)
        {
            ListNode? prev = null;
            var curr = head;
            while (curr != null)
            {
                if (curr.val == val)
                {
                    if (prev == null)
                        head = head.next;
                    else prev.next = curr.next;
                }
                else prev = curr;
                curr = curr.next;
            }
            return head;
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
