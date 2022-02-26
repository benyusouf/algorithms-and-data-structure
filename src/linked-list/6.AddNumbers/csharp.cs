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
 /// https://leetcode.com/problems/add-two-numbers/
 /// </summary>
 /*
 You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.
*/
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if(l1 == null) return l2;
        if(l2 == null) return l1;
        
        int carry = 0;
        ListNode head = null;
        
        while(l1 != null && l2 != null){
            int sum = l1.val + l2.val + carry;
            
            ListNode n = new ListNode(sum%10);
            
            n.next = head;
            head = n;
            carry = sum/10;
            
            l1 = l1.next;
            l2 = l2.next;
        }
        
        while(l1 != null){
            int sum = l1.val + carry;
            
            ListNode n = new ListNode(sum%10);
            
            n.next = head;
            head = n;
            carry = sum/10;
            
            l1 = l1.next;
        }
        
        while(l2 != null){
            int sum = l2.val + carry;
            
            ListNode n = new ListNode(sum%10);
            
            n.next = head;
            head = n;
            carry = sum/10;
            
            l2 = l2.next;
        }
        
        if(carry > 0){
            ListNode n = new ListNode(carry);
            n.next = head;
            head = n;
        }
        
        //reverse here
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