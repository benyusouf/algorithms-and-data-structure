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
 /// https://leetcode.com/problems/binary-tree-level-order-traversal/ 
 /// Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).
 /// </summary>
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> result = new List<IList<int>>();
        if(root == null) return result;
        
       Queue<TreeNode> que = new Queue<TreeNode>();
        IList<int> level = new List<int>();
        
        que.Enqueue(root);
        que.Enqueue(null);
        
        while(que.Count != 0){
            TreeNode node = que.Dequeue();
            
            if(node == null){
                IList<int> level1 = new List<int>(level);
                level.Clear();
                result.Add(level1);
                
                if(que.Count != 0) que.Enqueue(null);
            }
            else{
                if(node.left != null) que.Enqueue(node.left);
                if(node.right != null) que.Enqueue(node.right);

                level.Add(node.val);
            }     
        }
        
        return result;
    }
}