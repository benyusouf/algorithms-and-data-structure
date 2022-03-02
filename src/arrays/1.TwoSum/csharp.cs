
/// <summary>
/// https://leetcode.com/problems/two-sum/
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
/// </summary>
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        var result = new int[2];
        
        for(int i = 0; i < nums.Length; i++){
            if(map.ContainsKey(target-nums[i])){
                result[0] = map[target-nums[i]];
                result[1] = i;
                return result;
            }
            else if (!map.ContainsKey(nums[i])) map.Add(nums[i], i);
        }
        
        return result;
    }
}