/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
 /// <summary>
 /// https://www.interviewbit.com/problems/inorder-traversal-of-cartesian-tree/
 /// Given an inorder traversal of a cartesian tree, construct the tree.
 /// </summary>
class Solution {
    public TreeNode buildTree(List<int> A) {
        if(A == null || A.Count() == 0) return null;

        return Construct(A, 0, A.Count() -1);
    }

    public TreeNode Construct(IList<int> A, int start, int end){
        if(start > end) return null;

        int maxData = int.MinValue, maxIndex = -1;

        for(int i = start; i <= end; i++){
            if(A[i] > maxData) {
                maxData = A[i];
                maxIndex = i;
            }
        }

        TreeNode root = new TreeNode(maxData);

        root.left = Construct(A, start, maxIndex - 1);
        root.right = Construct(A, maxIndex + 1, end); 

        return root;
    }
}
