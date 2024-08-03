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

            while (temp != null) { 
                temp.data = st.Pop();
                temp = temp.next;
            }
            return head;
        }
    }
}
