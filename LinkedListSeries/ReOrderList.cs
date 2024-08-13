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
    }
}
