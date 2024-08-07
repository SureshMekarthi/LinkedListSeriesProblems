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

        public Node MergeTwoLL(Node list1, Node list2)
        {
            ArrayList arrayList = new ArrayList();
            Node temp1 = list1;
            Node temp2 = list2;

            while (temp1 != null)
            {
                arrayList.Add(temp1);
                temp1 = temp1.next;
            }

            while (temp2 != null)
            {
                arrayList.Add(temp2);
                temp2 = temp2.next;
            }

            arrayList.Sort();

            Node dummyNode = new Node(-1);
            Node temp = dummyNode;
            for (int i = 0; i < arrayList.Count; i++)
            {
                temp.next = new Node((int)arrayList[i]);

                temp = temp.next;

            }

            return dummyNode.next;
        }
    }
}
