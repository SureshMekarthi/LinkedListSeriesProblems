using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSeries
{
    public class ReOrderList
    {
        public static Node Middle(Node head)
        {
            Node slow = head;
            Node fast = head;

            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

        public static Node Reverse(Node head)
        {
            Node temp = head;
            Node prev = null;
            Node fort = null;

            while (temp != null)
            {
                fort = temp.next;
                temp.next = prev;
                prev = temp;
                temp = temp.next;
            }
            return prev;
        }

        public static void ReOrderLL(Node head)
        {
            if (head == null || head.next == null)
            { return ; }

            Node mid = Middle(head);

            Node k = Reverse(mid.next);
            mid.next = null;

            Node c1 = head;
            Node c2 = k;

            Node f1 = null;
            Node f2 = null;

            while (c1 != null && c2 != null)
            {

                f1 = c1.next;
                f2 = c2.next;

                c1.next = c2;
                c2.next = f1;

                c1 = f1;
                c2 = f2;
            }

        }
    }
}
