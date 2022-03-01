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
 /// https://leetcode.com/problems/validate-binary-search-tree/
 /// Given the root of a binary tree, determine if it is a valid binary search tree (BST).
 /// </summary>
public class Solution {
    public bool IsValidBST(TreeNode root) {
        return IsBetween(root);
    }
    
    static bool IsBetween(TreeNode root, long min = Int64.MinValue, long max = Int64.MaxValue){
        
        if(root == null) return true;
        
        var right = IsBetween(root.right, root.val, max);
        var left = IsBetween(root.left, min, root.val);
        
        return right && left && root.val > min && root.val < max;
    }
}