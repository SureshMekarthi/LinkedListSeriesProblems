using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSeries
{
    public class MergeTwoLists
    {
        // function to mergerd two sorted linkedlists

        public static Node MergeTwoLL(Node list1, Node list2)
        {
            List<int> list = new List<int>();
            Node temp1 = list1;
            Node temp2 = list2;

            while (temp1 != null)
            {
                list.Add(temp1.data);
                temp1 = temp1.next;
            }

            while (temp2 != null)
            {
                list.Add(temp2.data);
                temp2 = temp2.next;
            }

            list.Sort();

            Node dummyNode = new Node(-1);
            Node temp = dummyNode;
            for (int i = 0; i < list.Count; i++)
            {
                temp.next = new Node(list[i]);

                temp = temp.next;

            }

            return dummyNode.next;
        }

        public static void PrintLinkedList(Node head)
        {
            Node temp = head;

            while (temp != null)
            {
                Console.WriteLine($" {temp.data}");
                temp = temp.next;
            }
        }

        public static Node MergeTwoLLs(Node list1, Node list2)
        {
            Node dummyNode = new Node(-1);
            Node temp = dummyNode;

            while (list1 != null && list2 != null)
            {
                if (list1.data <= list2.data)
                {
                    temp.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    temp.next = list2;
                    list2 = list2.next;
                }
                temp = temp.next;
            }

            if (list1 != null)
            {
                temp.next = list1;
            }
            else
            {
                temp.next = list2;
            }

            return dummyNode.next;
        }
    }
}
