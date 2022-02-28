/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    struct ele{
        TreeNode* node;
        int HD;
    };
    vector<vector<int>> verticalTraversal(TreeNode* root) {
        vector<vector<int>> ans;
        if(root==NULL){
            return ans;
        }
        map<int, vector<int>> mymap;
        queue<ele> q;
        q.push({root,0});
        
        while(!q.empty()){
            ele front = q.front();
            q.pop();
            int currentHD = front.HD;
            TreeNode* currentNode = front.node;
            
            mymap[currentHD].push_back(currentNode->val);
            if(currentNode->left !=NULL){
                q.push({currentNode->left, currentHD-1});
            }
            if(currentNode->right != NULL){
                q.push({currentNode->right, currentHD+1});
            }
        }
        /// map is ready
       
        for(auto it = mymap.begin();it!=mymap.end();it++){
            vector<int> smallAns = it->second;
            sort(smallAns.begin(),smallAns.end());
            ans.push_back(smallAns);
        }
        return ans;
    }
};