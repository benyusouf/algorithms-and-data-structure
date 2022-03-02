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
 /// https://leetcode.com/problems/kth-smallest-element-in-a-bst/
 /// Given the root of a binary search tree, and an integer k, return the kth smallest value (1-indexed) of all the values of the nodes in the tree.
 /// </summary>
public class Solution {
    public int KthSmallest(TreeNode root, int k) { 
        int count = 0, ans = 1;
        Inorder(root, k, ref count, ref ans);
        
        return ans;
    }
    
    static void Inorder(TreeNode root, int k, ref int count, ref int ans){
        if(root == null) return;
        
        Inorder(root.left, k, ref count, ref ans);
        count++;
        if(count == k) {
            ans = root.val;
            return;
        };
        Inorder(root.right, k, ref count, ref ans);
    }
}