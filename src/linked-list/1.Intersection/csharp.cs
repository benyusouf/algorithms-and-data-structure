/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */



 /// <summary>
 /// https://leetcode.com/problems/intersection-of-two-linked-lists/
 /// </summary>
 /* Given the heads of two singly linked-lists headA and headB, 
 return the node at which the two lists intersect. 
 If the two linked lists have no intersection at all, return null.
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode A, ListNode B) {
        // while(headA != null){
        //     ListNode head2 = headB;
        //     while(head2 != null){
        //         if(headA == head2) return head2;
        //         head2 = head2.next;
        //     }
        //     headA = headA.next;
        // }
        // return null;
        
//         Dictionary<ListNode, bool> dic = new Dictionary<ListNode, bool>();
        
//         while(headA != null){
//             dic.Add(headA, true);
//             headA = headA.next;
//         }
        
//         while(headB != null){
//             if(dic.ContainsKey(headB)) return headB;
//             headB = headB.next;
//         }
        
//         return null;
        
        int m = Length(A);
        int n = Length(B);
        
        int d = Math.Abs(m-n);
        
        if(m > n) Swap(ref A, ref B);
        
        for(int i = 1; i <= d; i++){
            B = B.next;
        }
        
        while(A != null && B != null){
            if(A == B) return A;
            
            A = A.next;
            B = B.next;
        }
        
        return null;
    }
    
    void Swap(ref ListNode A, ref ListNode B){
        ListNode temp = A;
        A = B;
        B = temp;
    }
    
    int Length(ListNode node){
        int c = 0;
        
        while(node != null){
            c++;
            node = node.next;
        }
        return c;
    }
}