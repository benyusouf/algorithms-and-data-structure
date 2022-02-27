/// https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };
 */
class Solution {
public:
    vector<vector<int>> levelOrderBottom(TreeNode* root) {
         vector<vector<int> > v;
        if(root==NULL){
            return v;
        }
        vector<int> temp;   /// storing is storing result of current level
        
        queue<TreeNode*> q;
        q.push(root);
        q.push(NULL);
        
        while(!q.empty()){
            TreeNode* f = q.front();
            q.pop();
            if(f==NULL){
                ///cout<<endl;
                v.push_back(temp);
                temp.clear();
                if(!q.empty()){
                    q.push(NULL);
                }
                
            }else{
                temp.push_back(f->val);
                if(f->left){
                    q.push(f->left);
                }
                if(f->right){
                    q.push(f->right);
                }
            }
        }
        
        reverse(v.begin(),v.end());
        
        return v;
    }
};