/// <summary>
/// https://leetcode.com/problems/search-in-rotated-sorted-array/
/// </summary>
/*
There is an integer array nums sorted in ascending order (with distinct values).

Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 and become [4,5,6,7,0,1,2].

Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.
*/
public class Solution {
    public int Search(int[] nums, int key) {
        int s = 0, e = nums.Length -1;
        
        while(s <= e){
            int m = s + (e-s)/2;
            
            if(nums[m] == key) return m;
            
            if(nums[s] <= nums[m]){
                if(key >= nums[s] && key <= nums[m]){
                    e = m - 1;
                } else{
                    s = m + 1;
                }
            }
            else{
                if(key >= nums[m] && key <= nums[e]){
                    s = m + 1;
                } else{
                    e = m - 1;
                }
            }
        }
        
        return -1;
    }
}