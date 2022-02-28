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
 /// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
 /// Given a binary search tree (BST), find the lowest common ancestor (LCA) of two given nodes in the BST.
 /// </summary>

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        while(root != null){
            if(root.val < p.val && root.val < q.val)
                root = root.right;
            else if(root.val > p.val && root.val > q.val)
                root = root.left;
            else return root;
        }
        return null;
    }
}