/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
 /// <summary>
 /// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
 /// Given a binary tree, find the lowest common ancestor (LCA) of two given nodes in the tree.
 /// </summary>
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
        if(root == null) return null;
        
        if(p == null || q == null) return null;
        
        if(root.val == p.val || root.val == q.val) return root;
        
        var right = LowestCommonAncestor(root.right, p, q);
        var left = LowestCommonAncestor(root.left, p, q);
        
        if(right == null && left != null) return left;
        else if(right != null && left == null) return right;
        else if(right == null && left == null) return null;
        
        return root;
    }
}