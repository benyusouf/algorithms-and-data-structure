// https://leetcode.com/problems/same-tree/
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
    bool isSameTree(TreeNode* a, TreeNode* b) {
        if(a==NULL && b==NULL) return true;
        if(a==NULL && b!=NULL) return false;
        if(a!=NULL && b==NULL) return false;
        
        if(a->val==b->val && isSameTree(a->left,b->left) && isSameTree(a->right, b->right)){
            return true;
        }
        return false;
    }
};