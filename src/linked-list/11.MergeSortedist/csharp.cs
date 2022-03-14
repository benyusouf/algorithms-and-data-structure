/**
You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.


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
 /// https://leetcode.com/problems/merge-two-sorted-lists/
 /// </summary>
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head = null;
        ListNode tail = null;
        
        while(list1 != null && list2 != null){
            if(list1.val < list2.val){
                if(head == null){
                    head = list1;
                    tail = list1;
                }
                else{
                    tail.next = list1;
                    tail = list1;
                }
                list1 = list1.next;
            }
            else {
                if(head == null){
                    head = list2;
                    tail = list2;
                }
                else{
                    tail.next = list2;
                    tail = list2;
                }
                list2 = list2.next;
            }
        }
        
        while(list1 != null){
            if(head == null){
                    head = list1;
                    tail = list1;
                }
                else{
                    tail.next = list1;
                    tail = list1;
                }
                list1 = list1.next;
        }
        
        while(list2 != null){
            if(head == null){
                    head = list2;
                    tail = list2;
                }
                else{
                    tail.next = list2;
                    tail = list2;
                }
                list2 = list2.next;
        }
        
        return head;
    }
}