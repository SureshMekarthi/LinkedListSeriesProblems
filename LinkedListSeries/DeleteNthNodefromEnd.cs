using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSeries
{
    public class DeleteNthNodefromEnd
    {
        public static void PrintLL(Node head)
        {
            while (head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }
        }

        public static Node DeleteNthNode(Node head, int num)
        {
            int count = 0;
            Node temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            var result = count - num;
            if (result == 0)
            {
                return head.next;
            }
            temp = head;
            while (result > 0)
            {
                temp = temp.next;
            }
            temp.next = temp.next.next;
            return head;
        }
    }
}
