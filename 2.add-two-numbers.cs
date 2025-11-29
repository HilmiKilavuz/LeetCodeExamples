/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        Stack<int> stack = new Stack<int>();
        int carry = 0;


        while (l1 != null || l2 != null || carry != 0)
        {
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;

            int toplam = x + y + carry;
            carry = toplam / 10;
            int rakam = toplam % 10;

            stack.Push(rakam);

            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }

 
        ListNode sonuc = null;
        while (stack.Count > 0)
        {
            ListNode yeni = new ListNode(stack.Pop());
            yeni.next = sonuc;
            sonuc = yeni;
        }

        return sonuc;
    }
}

// @lc code=end

