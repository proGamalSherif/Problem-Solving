using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static LeetCode.Classes.EASY.MergeTwoSortedList;

namespace LeetCode.Classes.EASY
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
    internal class Remove_Duplicated_From_Sorted_List
    {
        public static void Run()
        {

            ListNode head = new ListNode(1);
            head.next = new ListNode(1);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(3);
            head.next.next.next.next = new ListNode(3);
            head = DeleteDuplicates(head);
           while(head != null)
            {
                Console.WriteLine(head.val);
                head = head.next;
            }




        }
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;

            List<int> arr = new List<int>();

            ListNode current = head;
            while (current != null)
            {
                if (!arr.Contains(current.val))
                {
                    arr.Add(current.val);
                }

                current = current.next;
            }
            ListNode returnedList = new ListNode(arr[0]);
            ListNode tail = returnedList;

            for (int i = 1; i < arr.Count; i++)
            {
                tail.next = new ListNode(arr[i]);
                tail = tail.next;
            }

            return returnedList;
        }

    }
}
