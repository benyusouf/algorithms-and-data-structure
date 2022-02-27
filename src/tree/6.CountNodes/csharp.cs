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
 /// https://leetcode.com/problems/count-complete-tree-nodes/ Given the root of a complete binary tree, return the number of the nodes in the tree.
 /// </summary>
public class Solution {
    public int CountNodes(TreeNode root) {
        if(root == null) return 0;
        
        return CountNodes(root.left) + 1 + CountNodes(root.right);
    }
}