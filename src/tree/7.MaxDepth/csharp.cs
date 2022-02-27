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
 /// https://leetcode.com/problems/maximum-depth-of-binary-tree/
 /// </summary>
//  Given the root of a binary tree, return its maximum depth.

// A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
public class Solution {
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}