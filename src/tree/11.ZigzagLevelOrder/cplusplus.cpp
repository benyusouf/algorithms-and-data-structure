/// https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
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
    vector<vector<int>> zigzagLevelOrder(TreeNode* root) {
        vector<vector<int> > result;
        if(root==NULL) return result;
        
        queue<TreeNode*> q;
        q.push(root);
        bool leftToRight = true;
        
        while(!q.empty()){
            int size = q.size();   /// how many nodes are present at this level
            vector<int> row(size);
            
            for(int i=0;i<size;i++){   /// traversal current level
                TreeNode *f = q.front();
                q.pop();
                
                int index = (leftToRight) ? i : (size-1-i);
                row[index] = f->val;
                
                if(f->left) q.push(f->left);
                if(f->right) q.push(f->right);
            }
            /// after current level
            leftToRight = !leftToRight;
            result.push_back(row);
        }
        return result;
    }
};