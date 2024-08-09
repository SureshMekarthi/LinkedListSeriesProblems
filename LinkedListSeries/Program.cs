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
            //List<int> arr = new List<int> { 12, 8, 5, 2, 8};
            ////int val = 100;

            ////// Creating a linked list with initial elements from the array
            //Node head = new Node(arr[0]);
            //head.next = new Node(arr[1]);
            //head.next.next = new Node(arr[2]);
            //head.next.next.next = new Node(arr[3]);

            //// Inserting a new node at the head of the linked list
            //head = Node.InsertHead(head, val);

            //// Printing the linked list
            //Node.PrintLL(head);

            //int[] array = { 12, 5, 6, 8 };
            //NodeD head = NodeD.ConvertArr2DLL(array);
            //NodeD.Print(head);


            Node list1 = new Node(1);
            list1.next = new Node(3);
            list1.next.next = new Node(5);

            Node list2 = new Node(2);
            list2.next = new Node(4);
            list2.next.next = new Node(6);

            Console.WriteLine("L1");
            MergeTwoLists.PrintLinkedList(list1);

            Console.WriteLine("L1");
            MergeTwoLists.PrintLinkedList(list2);

            Node mergeList = MergeTwoLists.MergeTwoLLs(list1, list2);

            Console.WriteLine("Merge List");
            MergeTwoLists.PrintLinkedList(mergeList);

            //Node middleNode = FindMiddleOfLinkedList.FindMiddle(head);

            //Console.WriteLine($" then middle node is: {middleNode.data}");

            //bool isloopinLL = DetectCycle.DetectLoop(head);
            //Console.WriteLine($" LoopinLL: {isloopinLL}");

            //head = NodeD.DeleteHead(head);
            //NodeD.Print(head);
            Console.ReadLine();
        }
    }
}
