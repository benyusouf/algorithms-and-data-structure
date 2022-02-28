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
public struct Ele{
    public TreeNode Node {get; set;}
    public int Hd {get; set;}
}

/// <summary>
/// https://leetcode.com/problems/vertical-order-traversal-of-a-binary-tree/ Given the root of a binary tree, calculate the vertical order traversal of the binary tree.
/// </summary>
public class Solution {
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        var result = new List<IList<int>>();
        if(root == null) return result;
        
        var q = new Queue<Ele>();
        q.Enqueue(new Ele{Node = root, Hd = 0});
        
        var dic = new SortedDictionary<int, List<int>>();
        
        while(q.Count != 0){
            Ele cur = q.Dequeue();
            TreeNode node = cur.Node;
            int hd = cur.Hd;
            
            if(dic.ContainsKey(hd)){
                dic[hd].Add(node.val);
            } else{
                dic.Add(hd, new List<int>{node.val});
            }
            
            if(node.left != null) q.Enqueue(new Ele{Node = node.left, Hd = hd-1});
            if(node.right != null) q.Enqueue(new Ele{Node = node.right, Hd = hd+1});
        }
        
        foreach(var kv in dic){
            kv.Value.Sort();
            result.Add(kv.Value);
        }
        
        return result;
    }
}