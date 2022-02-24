/// https://leetcode.com/problems/intersection-of-two-linked-lists/submissions/

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
    
    
    int length(ListNode* head){
        int count=0;
        while(head!=NULL){
            count++;
            head = head->next;
        }
        return count;
    }
    
    ListNode *getIntersectionNode(ListNode *A, ListNode *B) {
        /*while(A!=NULL){
             ListNode *head2 = B;
            while(head2!=NULL){
                if(A==head2){
                    return A;
                }
                
                head2= head2->next;
            }
            A = A->next;
            
        }
        return NULL;*/
        
        /*unordered_map<ListNode* , bool> mymap;
        while(B!=NULL){
            mymap[B] = true;
            B = B->next;
        }
        
        while(A!=NULL){
            if(mymap.count(A)) return A;  /// intersection
            A = A->next;
        }
        return NULL;
        */
        
        
        int m = length(A);
        int n = length(B);
        
        int d = abs(n-m);
        if(m>n)swap(A,B);
        /// B is bigger
        
        for(int i=0;i<d;i++){
            B = B->next;
        }
        
        /// A and B are equidistant
        while(A!=NULL && B!=NULL){
            if(A==B){
                return A;
            }
            
            A=A->next;
            B=B->next;
        }
        
        return NULL;
    }
};