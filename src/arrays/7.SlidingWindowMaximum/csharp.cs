/*
You are given an array of integers nums, there is a sliding window of size k which is moving from the very left of the array to the very right. You can only see the k numbers in the window. Each time the sliding window moves right by one position.

Return the max sliding window.
*/

/// <summary>
/// https://leetcode.com/problems/sliding-window-maximum/submissions/
/// </summary>
public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if(k == 0) return nums;
        
        int size = nums.Length;
        int ansSize = size - k + 1;
        int[] ans = new int[ansSize];
        
        LinkedList<int> q = new LinkedList<int>();
        
        for(int i = 0; i < size; i++){
            if(q.Count > 0 && q.First.Value + k <= i){
                q.RemoveFirst();
            }
            
            while(q.Count > 0 && nums[q.Last.Value] <= nums[i]){
                q.RemoveLast();
            }
            
            q.AddLast(i);
            
            int index = i + 1 - k;
            
            if(index >= 0){
                ans[index] = nums[q.First.Value];
            }
        }
        
        return ans;
    }
}