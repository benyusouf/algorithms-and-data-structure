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
 /// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
 /// Given two integer arrays preorder and inorder where preorder is the preorder traversal of 
 /// a binary tree and inorder is the inorder traversal of the same tree, construct and return the binary tree.
 /// </summary>
public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        int n = preorder.Length;
        
        return Build(inorder, preorder, 0, n-1, 0, n-1);
    }
    
    TreeNode Build(int[] ino, int[] pre, int inS, int inE, int prS, int prE){
        if(inS > inE) return null;
        
        int leftInS = inS, leftPrS = prS+1;
        int rightInE = inE, rightPrE = prE;
        
        int rootIndex = -1;
        
        for(int i = inS; i <= inE; i++){
            if(ino[i] == pre[prS]) {
                rootIndex = i;
                break;
            }
        }
        
        int leftInE = rootIndex - 1, rightInS = rootIndex + 1;
        int leftPrE = leftPrS + leftInE - leftInS;
        int rightPrS = leftPrE + 1;
        
        TreeNode left = Build(ino, pre, leftInS, leftInE, leftPrS, leftPrE);
        TreeNode right = Build(ino, pre, rightInS, rightInE, rightPrS, rightPrE);
        
        TreeNode root = new TreeNode(pre[prS]);
        root.left = left;
        root.right = right;
        
        return root;
    }
}