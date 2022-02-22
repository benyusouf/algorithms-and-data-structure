/// <summary>
/// https://leetcode.com/problems/single-number/
/// </summary>
/*
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.
*/
public class Solution {
    public int SingleNumber(int[] nums) {
        int a = 0;
        
        for(int i = 0; i < nums.Length; i++){
            a = a ^ nums[i];
        }
        
        return a;
    }
}