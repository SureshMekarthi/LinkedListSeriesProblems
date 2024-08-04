using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSeries
{
    public class DetectCycle
    {

        public static Boolean DetectLoop(Node head)
        {
            Node temp = head;

            Dictionary<Node, int> map = new Dictionary<Node, int>();

            while (temp != null)
            {
                if (map.ContainsKey(temp))
                {
                    return true;
                }
                map[temp] = 1;
                temp = temp.next;
            }
            return false;
        }
    }
}
