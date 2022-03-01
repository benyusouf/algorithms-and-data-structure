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
 /// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
 /// Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.
 /// A height-balanced binary tree is a binary tree in which the depth of the two subtrees of every node never differs by more than one.
 /// </summary>
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        return GetRoot(nums, 0, nums.Length-1);
    }
    
    TreeNode GetRoot(int[] nums, int s, int e){
        if(s > e) return null;
        
        int midIndex = s + (e-s)/2;
        
        TreeNode root = new TreeNode(nums[midIndex]);
        
        root.left = GetRoot(nums, s, midIndex-1);
        root.right = GetRoot(nums, midIndex+1, e);
        
        return root;
    }
}