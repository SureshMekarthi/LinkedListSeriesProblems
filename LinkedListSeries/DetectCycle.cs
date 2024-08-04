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

        public static bool SlowFastPointers(Node head)
        {

            Node temp = head;
            Node slow = head;
            Node fast = head;

            while (fast != null || fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if(fast==slow)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
