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
 /// <summary>
 /// https://leetcode.com/problems/reverse-linked-list/ 
 /// Given the head of a singly linked list, reverse the list, and return the reversed list.
 /// </summary>
public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        ListNode prev = null, cur = head;
        
        while(cur != null){
            ListNode next = cur.next;
            cur.next = prev;
            
            prev = cur;
            cur = next;
        }
        
        return prev;
    }
}