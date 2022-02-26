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
    public ListNode DeleteMiddle(ListNode head) {
        
        ListNode slow = head, fast = head.next, before = head;
        
        if(head.next == null){
            head = null;
        }
        
        while(fast != null){
            ListNode nextFast = fast.next;
            if(nextFast == null){
                before = slow;
                slow = slow.next;
                break;
            }
            before = slow;
            slow = slow.next;
            fast = nextFast.next;
        }
        
        before.next = slow.next;
        
        return head;
    }
}