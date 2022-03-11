/*
Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

A subarray is a contiguous part of an array.

*/

/// <summary>
/// https://leetcode.com/problems/maximum-subarray/
/// </summary>

public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = int.MinValue, curSum = 0;
        
        for(int i = 0; i < nums.Length; i++){
            curSum += nums[i];
            maxSum = Math.Max(maxSum, curSum);
            
            if(curSum < 0) curSum = 0;
        }
        
        return maxSum;
    }
}