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
 Given the head of a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.

You should preserve the original relative order of the nodes in each of the two partitions.
*/
 /// <summary>
 /// https://leetcode.com/problems/partition-list/
 /// </summary>
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        if(head == null || head.next == null) return head;
        
        ListNode A = null, B = null, C = null, D = null;
        
        while(head != null){
            if(head.val < x){
                if(A == null){
                    A = head;
                    C = head;
                }
                else{
                    C.next = head;
                    C = C.next;
                }
            }
            else{
                if(B == null){
                    B = head;
                    D = head;
                }
                else{
                    D.next = head;
                    D = D.next;
                }
            }
            head = head.next;
        }
        if(C != null) C.next = null;
        if(D != null) D.next = null;
        if(B == null && A != null) return A;
        else if(A == null && B != null) return B;
    
        C.next = B;
        return A;
    }
    
}