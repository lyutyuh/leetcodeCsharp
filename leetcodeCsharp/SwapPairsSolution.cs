using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeCsharp
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    class SwapPairsSolution
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null) {
                return head;
            }


            ListNode ans = null;
            ListNode tmp = null;
            ans = head.next;
            tmp = ans.next;
            ans.next = head;
            head.next = SwapPairs(tmp);

            return ans;

        }

    }
}
