using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 12, 8, 5, 7 };
            //int val = 100;

            //// Creating a linked list with initial elements from the array
            Node head = new Node(arr[0]);
            head.next = new Node(arr[1]);
            head.next.next = new Node(arr[2]);
            head.next.next.next = new Node(arr[3]);

            //// Inserting a new node at the head of the linked list
            //head = Node.InsertHead(head, val);

            //// Printing the linked list
            //Node.PrintLL(head);

            //int[] array = { 12, 5, 6, 8 };
            //NodeD head = NodeD.ConvertArr2DLL(array);
            //NodeD.Print(head);

           Node middleNode = FindMiddleOfLinkedList.FindMiddle(head);

            Console.WriteLine($" then middle node is: {middleNode.data}");

            //head = NodeD.DeleteHead(head);
            //NodeD.Print(head);
            Console.ReadLine();
        }
    }
}
