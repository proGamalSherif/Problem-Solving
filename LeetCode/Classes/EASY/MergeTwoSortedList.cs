using System;

namespace LeetCode.Classes.EASY
{
    internal class MergeTwoSortedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public static void Run()
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            MergeTwoSortedList mergeInstance = new MergeTwoSortedList();
            ListNode result = mergeInstance.MergeTwoLists(list1, list2);
            PrintList(result);
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            ListNode sortedHead = new ListNode();
            ListNode current = sortedHead;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }
            current.next = list1 ?? list2;

            return sortedHead.next;
        }
        private static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}
