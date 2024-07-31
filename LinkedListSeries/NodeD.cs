using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSeries
{
    public class NodeD
    {
        public int data;
        public NodeD next;
        public NodeD back;

        public NodeD(int data, NodeD next, NodeD back)
        {
            this.data = data;
            this.next = next;
            this.back = back;
        }
        public NodeD(int data)
        {
            this.data = data;
            next = null;
            back = null;
        }

        public static NodeD ConvertArr2DLL(int[] arr)
        {
            NodeD head = new NodeD(arr[0]);
            NodeD prev = head;

            for (int i = 1; i < arr.Length; i++)
            {
                NodeD temp = new NodeD(arr[i], null, prev);
                prev.next = temp;
                prev = temp;
            }
            return head;
        }

        public static NodeD DeleteTail(NodeD head)
        {
            if (head == null || head.next == null)
                return null;


            NodeD tail = head;

            while (tail.next != null)
            {
                tail = tail.next;
            }

            NodeD newTail = tail.back;
            newTail.next = null;
            tail.back = null;

            return head;
        }

        public static NodeD DeleteHead(NodeD head)
        {
            {
                if (head == null || head.next == null) return null;

                NodeD prev = head;
                head = head.next;
                head.back = null;
                prev.next = null;
                return head;
            }

        }
        public static void Print(NodeD head)
        {
            while (head != null)
            {
                Console.WriteLine($" {head.data}");
                head = head.next;
            }
        }
    }
}
