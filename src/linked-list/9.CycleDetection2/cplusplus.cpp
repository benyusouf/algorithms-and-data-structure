/// https://leetcode.com/problems/linked-list-cycle/
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
    bool hasCycle(ListNode *A) {
        /*
        unordered_map<ListNode* ,bool> mymap;
        while(A!=NULL){
            if(mymap.count(A)){
                return true;
            }
            mymap[A] = true;
            A=A->next;
        }
        return false;
        */
        
        ListNode *slow = A, *fast=A;
        while(fast && fast->next){
            fast = fast->next->next;  /// to avoid runtime
            slow = slow->next;
            
            if(slow==fast){
                return true;
            }
        }
        return false;
    }
};