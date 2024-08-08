using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PalindromeLinkedListProblem
    {
        public static bool IsPalindrome(ListNode? head)
        {
            if (head == null) return false;
            if (head.next == null) return true;
            var tortoise = head;
            var hare = head;
            //find mid node
            while (hare != null && hare.next != null)
            {
                hare = hare.next.next;
                tortoise = tortoise.next;
            }
            var mid = tortoise;
            ListNode? prev = null;
            //reverse after mid
            while (mid != null)
            {
                var next = mid.next;
                mid.next = prev;
                prev = mid;
                mid = next;
            }
            while (head != null && prev != null)
            {
                if (head.val != prev.val) return false;
                head = head.next;
                prev = prev.next;
            }
            return true;
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
