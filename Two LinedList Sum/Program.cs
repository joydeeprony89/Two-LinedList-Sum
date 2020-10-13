using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Two_LinedList_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
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

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            Stack<int> s1 = new Stack<int>();
            Stack<int> s2 = new Stack<int>();
            while (l1 != null)
            {
                s1.Push(l1.val);
                l1 = l1.next;

            }
            while (l2 != null)
            {
                s2.Push(l2.val);
                l2 = l2.next;
            }

            int carry = 0;
            ListNode dummy = null;
            while(s1.Count > 0 || s2.Count > 0 || carry != 0)
            {
                int sum = 0;
                if (s1.Count > 0) sum += s1.Pop();
                if (s2.Count > 0) sum += s2.Pop();
                sum = sum + carry;
                ListNode node = new ListNode(sum % 10);
                carry = sum / 10;
                node.next = dummy;
                dummy = node;
            }

            return dummy.next;
        }
    }
}
