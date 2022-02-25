/// https://leetcode.com/problems/reverse-linked-list/submissions/

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
    ListNode* reverseList(ListNode* head) {
         ListNode *curr = head;
         ListNode *prev = NULL;
        
        while(curr!=NULL){
            ListNode *n = curr->next;
            curr->next = prev;
            
            prev = curr;
            curr= n;
        }
        
        return prev;
    }
};