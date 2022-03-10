/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    
    struct mycmp{
        bool operator()(ListNode* a, ListNode* b){
            return a->val > b->val;
        }
    };
    
    ListNode* mergeKLists(vector<ListNode*>& lists) {
        priority_queue<ListNode*, vector<ListNode*>, mycmp> pq;  /// minHeap
        for(int i=0;i<lists.size();i++){
            if(lists[i]!=NULL){
                pq.push(lists[i]);
            }
        }
        ListNode* head = NULL;
        ListNode* tail = NULL;
        while(!pq.empty()){
            ListNode* temp = pq.top();
            pq.pop();
            
            if(head==NULL){
                head = tail = temp;
            }else{
                tail->next = temp;
                tail = temp;
            }
            if(temp->next !=NULL){
                pq.push(temp->next);
            }
        }
        return head;
    }
};