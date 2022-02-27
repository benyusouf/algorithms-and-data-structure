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
 /// https://leetcode.com/problems/binary-tree-postorder-traversal/ Given the root of a binary tree, return the postorder traversal of its nodes' values.
 /// </summary>
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
    var result = new List<int>();
        
        Traverse(root, result);
        
        return result;
    }
    
    static void Traverse(TreeNode root, IList result){
        if(root == null) return;
        

        Traverse(root.left, result);
        Traverse(root.right, result);
        result.Add(root.val);
    }
}