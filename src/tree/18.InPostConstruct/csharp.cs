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
 /// https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
 /// Given two integer arrays inorder and postorder where inorder is the inorder traversal of a 
 /// binary tree and postorder is the postorder traversal of the same tree, construct and return the binary tree.
 /// </summary>
public class Solution {
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        // if(inorder == null || postorder == null) return null;
        // if(inorder.Length != postorder.Length) return null;
        
        int n = inorder.Length;
        
        return Construct(inorder, postorder, 0, n-1, 0, n-1);
    }
    
    TreeNode Construct(int[] ino, int[] pos, int inS, int inE, int poS, int poE){
        if(inS > inE) return null;
        
        int rootData = pos[poE];
        
        int rootIndex = - 1;
        
        for(int i = inS; i <= inE; i++){
            if(ino[i] == rootData){
                rootIndex = i;
                break;
            }
        }
        
        int leftInS = inS, 
        leftInE = rootIndex - 1, 
        leftPoS = poS;
        int leftPoE = leftPoS + leftInE - leftInS;
        
        int rightInS = rootIndex + 1, 
        rightInE = inE, 
        rightPoS = leftPoE + 1, 
        rightPoE = poE - 1;
        
        
        TreeNode root = new TreeNode(rootData);
        
        root.left = Construct(ino, pos, leftInS, leftInE, leftPoS, leftPoE);
        root.right = Construct(ino, pos, rightInS, rightInE, rightPoS, rightPoE);
        
        return root;
    }
}