/*
You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security systems connected and it will automatically contact the police if two adjacent houses were broken into on the same night.

Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.
*/
/// <summary>
/// https://leetcode.com/problems/house-robber/
/// </summary>
public class Solution {
    public int Rob(int[] nums) {
//         int even = 0, odd = 0;
        
//         for(int i = 0; i < nums.Length; i++){
//             if(i%2 == 0){
//                 even = Math.Max(even+nums[i], odd);
//             }
//             else{
//                 odd = Math.Max(odd + nums[i], even);
//             }
//         }
        
//         return Math.Max(even, odd);
        // int[] dp = new int[nums.Length + 1];
        // Array.Fill(dp, -1);
        // return Rec(nums, nums.Length - 1, dp);
        return Rec3(nums, nums.Length - 1);
    }
    
    int Rec(int[] nums, int n, int[] dp){
        if(n < 0) return 0;
        if(dp[n] >= 0) return dp[n];
        int ans = Math.Max(Rec(nums, n-2, dp)+nums[n], Rec(nums, n-1, dp));
        dp[n] = ans;
        return ans;
    }
    
    int Rec3(int[] nums, int n){
        int[] dp = new int[nums.Length + 1];
        dp[0] = 0;
        dp[1] = nums[0];
        
        for(int i = 1; i < nums.Length; i++){
            dp[i+1] = Math.Max(dp[i-1] + nums[i], dp[i]);
        }
        return dp[nums.Length];
    }
}