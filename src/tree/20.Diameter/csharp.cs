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
 /// https://leetcode.com/problems/diameter-of-binary-tree/
 /// Given the root of a binary tree, return the length of the diameter of the tree.
 /// The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.
 /// The length of a path between two nodes is represented by the number of edges between them.
 /// </summary>
public class Solution {
    public int DiameterOfBinaryTree(TreeNode root) {
        var heightDiameter = GetHeightDiameter(root);
        
        return heightDiameter.Value;
        
//         if(root == null) return 0;
        
//         int option1 = Height(root.left) + Height(root.right);
//         int option2 = DiameterOfBinaryTree(root.left);
//         int option3 = DiameterOfBinaryTree(root.right);
        
//         return Math.Max(option1, Math.Max(option2, option3));
    }
    
    int Height(TreeNode root){
        if(root == null) return 0;
        
        return 1 + Math.Max(Height(root.left), Height(root.right));
    }
    
    static KeyValuePair<int, int> GetHeightDiameter(TreeNode root){
        if(root == null)
            return new KeyValuePair<int, int>(0, 0);
        
        var left = GetHeightDiameter(root.left);
        var right = GetHeightDiameter(root.right);
        
        int leftHeight = left.Key, leftDiameter = left.Value,
        rightHeight = right.Key, rightDiameter = right.Value;
        
        int height = 1 + Math.Max(leftHeight, rightHeight);
        int diameter = Math.Max(leftHeight+rightHeight, Math.Max(leftDiameter, rightDiameter));
        
        return new KeyValuePair<int, int>(height, diameter);
    }
}