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
 /// https://leetcode.com/problems/invert-binary-tree/
 /// Given the root of a binary tree, invert the tree, and return its root.
 /// </summary>
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if(root == null) return null;
        
        var temp = root.left;
        root.left = root.right;
        root.right = temp;
        InvertTree(root.left);
        InvertTree(root.right);
        return root;
        
    }
}