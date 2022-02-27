/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
 /// <summary>
 /// https://leetcode.com/problems/symmetric-tree/ Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
 /// </summary>
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if(root == null) return true;
        
        return Symmetric(root.left, root.right);
    }
    
    bool Symmetric(TreeNode left, TreeNode right){
        if(left == null && right == null) return true;
        if(left == null && right != null) return false;
        if(left != null && right == null) return false;
        
        return left.val == right.val &&
         Symmetric(left.left, right.right) &&
            Symmetric(left.right, right.left);
    }
}