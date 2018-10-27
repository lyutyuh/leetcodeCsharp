using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeCsharp
{
    class RemoveNthFromEndSolution
    {
        private int GetLength(ListNode head)
        {
            int ans = 0;
            ListNode ptr = head;
            while (ptr != null) {
                ans += 1;
                ptr = ptr.next;
            }
            return ans;
        }
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int tally = 0;
            n = GetLength(head) - n;
            ListNode newHead = head;
            ListNode ptr = head;
            if (n > 0) {
                //Console.WriteLine(n);
                while (tally < n - 1) {
                    tally += 1;
                    ptr = ptr.next;
                }
                if (ptr.next != null) {
                    ptr.next = ptr.next.next;
                }
                else {
                    ptr = null;
                    Console.WriteLine(n);
                }
            }
            else {
                //Console.WriteLine(n);
                newHead = head.next;
            }
            return newHead;
        }
    }
}
