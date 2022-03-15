/**
Given the head of a linked list, return the list after sorting it in ascending order.
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
 /// https://leetcode.com/problems/sort-list/
 /// </summary>
public class Solution {
    public ListNode SortList(ListNode head) {
        if(head == null || head.next == null) return head;
        
       
        
        ListNode temp = null;
        ListNode slow = head;
        ListNode fast = head;
        
        while(fast !=  null && fast.next != null)
        {
            temp = slow;
            slow = slow.next;          
            fast = fast.next.next;  
            
        }   
        temp.next = null;            
        
        ListNode l1 = SortList(head);   
        ListNode l2 = SortList(slow);    
        
        return MergeSortedLists(l1, l2); 
    }
    
    ListNode MergeSortedLists(ListNode l1, ListNode l2){
        ListNode head = null;
        ListNode tail = null;
        
        while(l1 != null && l2 != null){
            if(l1.val < l2.val){
                if(head == null){
                    head = l1;
                    tail = l1;
                }
                else{
                    tail.next = l1;
                    tail = l1;
                }
                
                l1 = l1.next;
            }
            else{
                if(head == null){
                    head = l2;
                    tail = l2;
                }
                else{
                    tail.next = l2;
                    tail = l2;
                }
                l2 = l2.next;
            }
        }
        
        while(l1 != null){
            if(head == null){
                    head = l1;
                    tail = l1;
                }
                else{
                    tail.next = l1;
                    tail = l1;
                }
                
                l1 = l1.next;
        }
        
        while(l2 != null){
            if(head == null){
                    head = l2;
                    tail = l2;
                }
                else{
                    tail.next = l2;
                    tail = l2;
                }
                
                l2 = l2.next;
        }
        
        return head;
    }
    
}