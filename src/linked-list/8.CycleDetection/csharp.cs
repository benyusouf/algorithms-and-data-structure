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
 /*
 Given head, the head of a linked list, determine if the linked list has a cycle in it.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.

Return true if there is a cycle in the linked list. Otherwise, return false.
*/
 /// <summary>
 /// https://leetcode.com/problems/linked-list-cycle/
 /// </summary>
public class Solution {
    public bool HasCycle(ListNode head) {
//         var dic = new Dictionary<ListNode, bool>();
        
//         while(head != null){
//             if(dic.ContainsKey(head)) return true;
//             dic.Add(head, true);
//             head = head.next;
//         }
//         return false;
        
        ListNode slow = head, fast = head;
        
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
            
            if(fast == slow) return true;
        }
        
        return false;
    }
}