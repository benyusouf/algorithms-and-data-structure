/// <summary>
/// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
/// Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

/// If target is not found in the array, return [-1, -1].

/// You must write an algorithm with O(log n) runtime complexity.
/// </summary>


public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] ans = {-1, -1};
        
        int first = FindIndex(nums, target, true);
        
        if(first == -1) return ans;
        
        ans[0] = first;
        ans[1] = FindIndex(nums, target, false);
        
        return ans;
    }
    
    
    int FindIndex(int[] nums, int key, bool first){
        int s = 0, e = nums.Length -1, ans = -1;
        
        while(s <= e){
            int m = s + (e-s)/2;
            
            if(nums[m] == key){
                ans = m;
                if(first) e = m - 1;
                else s = m +1;
            } else if(nums[m] < key){
                s = m + 1;
            }
            else{
                e = m - 1;
            }
        }
        
        return ans;
    }
}