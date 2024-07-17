using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSeries
{
    public class Node
    {
        public int data;
        public Node next;

        // Constructor with both data and next node
        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;
        }

        // Constructor with only data (assuming next is initially null)
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }

        // Function to print the linked list
        public static void PrintLL(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
        }

        // Function to insert a new node at the head of the linked list
        public static Node InsertHead(Node head, int val)
        {
            Node temp = new Node(val, head);
            return temp;
        }
    }
}
