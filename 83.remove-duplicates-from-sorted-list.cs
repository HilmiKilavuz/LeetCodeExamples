/*
 * @lc app=leetcode id=83 lang=csharp
 *
 * [83] Remove Duplicates from Sorted List
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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode  now=head;
        while (now!=null&&now.next!=null)
        {
            if (now.val==now.next.val)
            {
                now.next=now.next.next;


            }
            else
            {
                now=now.next;
            }
            
        }
        return head;
    }
}
// @lc code=end

