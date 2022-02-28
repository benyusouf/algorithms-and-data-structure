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
 /// https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
 /// Given the root of a binary tree, return the zigzag level order traversal of its nodes' values. 
 /// (i.e., from left to right, then right to left for the next level and alternate between).
 /// </summary>
public class Solution {
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        List<IList<int>> result = new List<IList<int>>();
        if(root == null) return result;
        
       Queue<TreeNode> q = new Queue<TreeNode>();
        bool left = true;
        
        q.Enqueue(root);
        
        while(q.Count != 0){
            int size = q.Count;
            int[] level = new int[size];
            
            for(int i = 0; i < size; i++){
                TreeNode node = q.Dequeue();
                int index = left ? i : (size - 1 - i);
                level[index] = node.val;
                
                if(node.left != null) q.Enqueue(node.left);
                if(node.right != null) q.Enqueue(node.right);
            }
            left = !left;
            result.Add(level.ToList());
        }
        
        return result;
    }
}