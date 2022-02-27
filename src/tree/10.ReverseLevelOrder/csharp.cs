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
 /// https://leetcode.com/problems/binary-tree-level-order-traversal-ii/ Given the root of a binary tree, 
 /// return the bottom-up level order traversal of its nodes' values. (i.e., from left to right, level by level from leaf to root).
 /// </summary>
public class Solution {
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        
        if(root == null) return result;
        
        IList<int> level = new List<int>();
        
        Queue<TreeNode> que = new Queue<TreeNode>();
        que.Enqueue(root);
        que.Enqueue(null);
        
        Stack<IList<int>> st = new Stack<IList<int>>();
        
        while(que.Count != 0){
            TreeNode node = que.Dequeue();
            
            if(node == null){
                IList<int> temp = new List<int>(level);
                level.Clear();
                st.Push(temp);
                
                if(que.Count != 0) que.Enqueue(null);
            }
            else{
                if(node.left != null) que.Enqueue(node.left);
                if(node.right != null) que.Enqueue(node.right);
                
                level.Add(node.val);
            }
        }
        
        while(st.Count != 0){
            result.Add(st.Pop());
        }
        
        return result;
    }
}