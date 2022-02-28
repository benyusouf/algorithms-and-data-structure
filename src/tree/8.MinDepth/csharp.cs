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
        
//         if(root.left == null && root.right != null)
//             return 1 + MinDepth(root.right);
//         if(root.left != null && root.right == null)
//             return 1 + MinDepth(root.left);
        
//         return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right)); 
        
//         int minDepth = 0;
        
//         Queue<TreeNode> q = new Queue<TreeNode>();
//         q.Enqueue(root);
        
//         while(q.Count != 0){
//             int size = q.Count;
//             minDepth++;
//             for(int i = 0; i < size; i++){
//                 TreeNode node = q.Dequeue();
                
//                 if(node.left == null && node.right == null) return minDepth;
                
//                 if(node.left != null) q.Enqueue(node.left);
//                 if(node.right != null) q.Enqueue(node.right);
//             }
//         }
        
//         return minDepth;
        
        Queue<KeyValuePair<TreeNode, int>> q = new Queue<KeyValuePair<TreeNode, int>>();
        q.Enqueue(new KeyValuePair<TreeNode, int>(root, 1));
        
        while(q.Count != 0){
            
            KeyValuePair<TreeNode, int> front = q.Dequeue();

            if(front.Key.left == null && front.Key.right == null) return front.Value;

            if(front.Key.left != null) q.Enqueue(new KeyValuePair<TreeNode, int>(front.Key.left, front.Value +1));
            if(front.Key.right != null) q.Enqueue(new KeyValuePair<TreeNode, int>(front.Key.right, front.Value +1));
        }
        
        return 0;
    }
}