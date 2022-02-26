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
 /// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
 /// Given the head of a linked list, remove the nth node from the end of the list and return its head.
 /// </summary>
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head == null || head.next == null) return null;
        
        ListNode first = head;
        ListNode second = head;
        
        while(n > 0){
            second = second.next;
            n--;
        }
        
        if(second == null){
            return first.next;
        }
        
        while(second.next != null){
            first = first.next;
            second = second.next;
        }
        
        ListNode next = first.next;
        
        first.next = next.next;
        
        return head;
    }
}