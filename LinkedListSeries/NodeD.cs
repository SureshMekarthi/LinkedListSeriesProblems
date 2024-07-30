using System;
using System.Collections.Generic;
using System.Linq;
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

        private static NodeD ConvertArr2DLL(int[] arr)
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

    }
}
