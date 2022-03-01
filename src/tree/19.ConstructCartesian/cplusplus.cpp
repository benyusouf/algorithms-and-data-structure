/**
 * Definition for binary tree
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };
 */
 
TreeNode* helper(vector<int> inorder, int s, int e){
    if(s > e){
        return NULL;
    }
    /// find max ele bcoz that ele is my root
    int maxVal = INT_MIN;
    int maxIndex = -1;
    for(int i=s;i<=e;i++){
        if(inorder[i] > maxVal){
            maxVal = inorder[i];
            maxIndex = i;
        }
    }
    TreeNode* root = new TreeNode(maxVal);
    root->left = helper(inorder, s, maxIndex - 1);
    root->right = helper(inorder, maxIndex+1, e);
    return root;
}
 
TreeNode* Solution::buildTree(vector<int> &inorder) {
    if(inorder.size()==0){
        return NULL;
    }
    return helper(inorder, 0, inorder.size()-1);
}
