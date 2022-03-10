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

 /*

 You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.

Merge all the linked-lists into one sorted linked-list and return it.

*/

/// <summary>
/// https://leetcode.com/problems/merge-k-sorted-lists/
/// </summary>
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode, int> q = new PriorityQueue<ListNode, int>();
        
        foreach(ListNode listNode in lists){
            if(listNode != null){
                q.Enqueue(listNode, listNode.val);
            }
        }
        
        ListNode head = null, tail = null;
        
        while(q.Count > 0){
           ListNode front = q.Dequeue();
            
            if(head == null){
                head = tail = front;
            }
            else{
                tail.next = front;
                tail = front;
            }
            
            if(front.next != null){
                q.Enqueue(front.next, front.next.val);
            }
        }
        
        return head;
    }
}