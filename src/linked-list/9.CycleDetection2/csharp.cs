/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        ListNode slow = head, fast = head;
        
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
            
            if(fast == slow) break;;
        }
        
        if(fast == null || fast.next == null) return null;
        
        int count = 1;
        slow = slow.next;
        
        while(slow != fast){
            count++;
            slow = slow.next;
        }
        
        ListNode first = head, second = head;
        
        for(int i = 1; i <= count; i++){
            second = second.next;
        }
        
        while(second != first){
            first = first.next;
            second = second.next;
        }
        
        return second;
    }
}