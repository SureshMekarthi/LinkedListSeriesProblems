using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSeries
{
    public class FindMiddleOfLinkedList
    {
        public static Node FindMiddle(Node head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            Node temp = head;
            int count = 0;

            while (temp != null)
            {
                count++;
                temp = temp.next;
            }

            int mid = count / 2 + 1;

            temp = head;

            while (temp != null)
            {
                mid--;
                if (mid == 0)
                {
                    break;
                }
                temp = temp.next;
            }

            return temp;
        }
    }
}
