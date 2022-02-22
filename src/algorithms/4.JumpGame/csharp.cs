/// <summary>
/// https://leetcode.com/problems/jump-game/
/// </summary>
/*
You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.

Return true if you can reach the last index, or false otherwise.
*/
public class Solution {
    public bool CanJump(int[] nums) {
        int rMostGoodIndex = nums.Length - 1;
        
        for(int i = rMostGoodIndex - 1; i >= 0; i--){
            if(i + nums[i] >= rMostGoodIndex){
                rMostGoodIndex = i;
            }
        }
        
        if(rMostGoodIndex == 0) return true;
        
        return false;
    }
}