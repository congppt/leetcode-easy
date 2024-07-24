using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MergeTwoSortedListsProblem
    {
        public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
        {
            if (list1 == null && list2 == null) return null;
            if (list1 == null) return list2;
            if (list2 ==null) return list1;
            var result = new ListNode();
            if (list2.val <= list1.val)
            {
                result.val = list2.val;
                result.next = MergeTwoLists(list1, list2.next);
            } else
            {
                result.val = list1.val;
                result.next = MergeTwoLists(list1.next, list2);
            }
            return result;
        }
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
