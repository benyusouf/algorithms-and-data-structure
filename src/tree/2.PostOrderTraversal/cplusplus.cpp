/// https://leetcode.com/problems/binary-tree-preorder-traversal/
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
    void preorder(TreeNode *root,vector<int> &ans){
        if(root==NULL) return;
        
        ans.push_back(root->val); /// data
        preorder(root->left,ans); // left
        preorder(root->right,ans);  // right
    } 
        
    vector<int> preorderTraversal(TreeNode* root) {
        vector<int> ans;
        preorder(root,ans);
        
        return ans;
    }
};