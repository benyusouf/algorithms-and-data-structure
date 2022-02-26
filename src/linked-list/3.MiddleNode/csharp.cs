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
    public ListNode MiddleNode(ListNode head) {
        ListNode slow = head, fast = head.next;
        
        while(fast != null){
            ListNode nextFast = fast.next;
            if(nextFast == null) return slow.next;
            
            slow = slow.next; 
            fast = nextFast.next;
        }
        
        return slow;
    }
}