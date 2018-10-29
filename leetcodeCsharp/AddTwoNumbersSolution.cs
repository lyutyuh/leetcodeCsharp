using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tryCSharp
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class AddTwoNumbersSolution
    {

        private ListNode RecurAdd(ListNode l1, ListNode l2, int carry)
        {
            ListNode ans = new ListNode(0);
            ListNode returned = null;
            int nextcarry = 0;
            if (l1 != null && l2 != null)
            {
                ans.val = (l1.val + l2.val + carry) % 10;
                nextcarry = (l1.val + l2.val + carry) / 10;
                returned = RecurAdd(l1.next, l2.next, nextcarry);
                ans.next = returned;
            }
            else
            {
                if(l1 == null && l2 != null)
                {
                    l1 = new ListNode(0);
                    ans = RecurAdd(l1, l2, carry);
                }
                else if(l1 != null && l2 == null)
                {
                    l2 = new ListNode(0);
                    ans = RecurAdd(l1, l2, carry);
                }
                else
                {
                    if(carry == 0)
                    {
                        ans = null;
                    }
                    else
                    {
                        ans = new ListNode(1);
                    }
                }
            }


            return ans;
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode ans = RecurAdd(l1, l2, 0);
            return ans;
        }


    }
}
