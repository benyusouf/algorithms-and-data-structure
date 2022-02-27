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
 /// https://leetcode.com/problems/minimum-depth-of-binary-tree/
 /// </summary>
 
//  Given a binary tree, find its minimum depth.

// The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

// Note: A leaf is a node with no children.
public class Solution {
    public int MinDepth(TreeNode root) {
       if(root == null) return 0;
        
        if(root.left == null && root.right != null)
            return 1 + MinDepth(root.right);
        if(root.left != null && root.right == null)
            return 1 + MinDepth(root.left);
        
        return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right)); 
    }
}