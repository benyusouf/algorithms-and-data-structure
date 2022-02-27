/// https://leetcode.com/problems/partition-list
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
    ListNode* partition(ListNode* A, int x) {
        
        ListNode *LH = NULL , *LT = NULL , *MH = NULL , *MT = NULL;
        
        while(A!=NULL){
            
            if(A->val < x){
                if(LH==NULL){
                    LH=LT=A;
                }else{
                    /// insert at tail
                    LT->next = A;
                    LT = A; /// Lt = LT->next
                }
            } else {
                if(MH==NULL){
                    MH=MT=A;
                }else{
                    /// insert at tail
                    MT->next = A;
                    MT = A; /// Lt = LT->next
                }
            }
            
            A = A->next;
        }
        
        /// less and more are ready
        
        if(LH!=NULL && MH==NULL){
            LT->next = NULL; 
            return LH;
        } else if(LH==NULL && MH!=NULL){
             MT->next = NULL;
            return MH;
        } else if(LH!=NULL && MH!=NULL) {
             LT->next = NULL; 
              MT->next = NULL;
            
            LT ->next = MH;
            return LH;
        } else{
            return NULL;
        }
        
    }
};