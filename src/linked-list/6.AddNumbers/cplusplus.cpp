/// https://leetcode.com/problems/add-two-numbers
/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    ListNode* addTwoNumbers(ListNode* A, ListNode* B) {
         if(A==NULL) return B;
        if(B==NULL) return A;
        int carry = 0;
        
        ListNode *head = NULL;
        
        while(A!=NULL && B!=NULL){
            int sum = A->val + B->val + carry;
            ListNode *n = new ListNode(sum%10);
            n->next = head;   /// insert at head
            head = n;
            carry = sum/10;
            
            A = A->next;
            B = B->next;
        }
        
        while(A!=NULL){
            int sum = A->val + carry;
            ListNode *n = new ListNode(sum%10);
            n->next = head;   /// insert at head
            head = n;
            carry = sum/10;
            
            A = A->next;
        }
        
         while(B!=NULL){
            int sum = B->val + carry;
            ListNode *n = new ListNode(sum%10);
            n->next = head;   /// insert at head
            head = n;
            carry = sum/10;
            
            B = B->next;
        }
        
        if(carry>0){
            ListNode *n = new ListNode(carry);
            n->next = head;   /// insert at head
            head = n;
        }
        
        
        /// Reverse
        ListNode *prev = NULL;
        ListNode *curr = head;
        
        while(curr!=NULL){
            ListNode *n = curr->next;
            curr->next = prev;
            
            prev = curr;
            curr = n;
        }
        
        head = prev;
        
        return head;
    }
};