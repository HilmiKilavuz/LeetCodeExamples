/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode mergeNode = new ListNode();
        ListNode mergeLast = new ListNode(); 
        
        if(list1 == null){
            return list2;
        } else if(list2 == null){
            return list1;
        }

        if(list1.val <= list2.val){
            mergeNode.val = list1.val;             
            mergeLast = mergeNode;           
            list1 = list1.next;
        } else {
            mergeNode.val = list2.val;
            mergeLast = mergeNode;             
            list2 = list2.next;
        }

    
        while(list1 != null && list2 != null){ 
            
            if(list1.val <= list2.val){
                mergeLast.next = list1;
                list1 = list1.next;
            } else {
                mergeLast.next = list2;
                list2 = list2.next;
            }
            mergeLast = mergeLast.next;
        }


        if (list1 != null) {
            mergeLast.next = list1;
        } else {
            mergeLast.next = list2;
        }

        return mergeNode;
    }
}
// @lc code=end

