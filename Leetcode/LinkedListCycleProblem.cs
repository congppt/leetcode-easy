using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LinkedListCycleProblem
    {
        public bool HasCycle(ListNode? head)
        {
            if (head?.next == null) return false;
            //tortoise & hare
            ListNode? slow = head;
            ListNode? fast = head;
            while (slow != null && fast?.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) return true;
            }
            return false;
        }
        public class ListNode
        {
            public int val;
            public ListNode? next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
    }
}
