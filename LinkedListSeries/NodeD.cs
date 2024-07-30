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

    }
}
