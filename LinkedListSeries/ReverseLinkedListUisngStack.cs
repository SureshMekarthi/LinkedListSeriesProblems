using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSeries
{
    public class ReverseLinkedListUisngStack
    {
        public static Node ReverseLinkedList(Node head)
        {
            Node temp = head;

            Stack<int> st = new Stack<int>();

            while (temp != null)
            {
                st.Push(temp.data);
                temp = temp.next;
            }

            temp = head;

            while (temp != null)
            {
                temp.data = st.Pop();
                temp = temp.next;
            }
            return head;
        }

        public static Node reverseLinkedList(Node head)
        {
            Node temp = head;

            Node prev = null;

            while (temp != null)
            {
                Node front = temp.next;
                temp.next = prev;

                prev = temp;

                temp = front;
            }
            return prev;

        }

        public static Node ReverseLinkedListRecursive(Node head)
        {
            if (head == null || head.next == null) { return head; }

            Node newHead = ReverseLinkedListRecursive(head.next);

            Node front = head.next;

            front.next = head;
            head.next = null;

            return newHead;





        }
    }
}
