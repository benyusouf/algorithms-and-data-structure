/// <summary>
/// https://leetcode.com/problems/majority-element/submissions/
/// Given an array nums of size n, return the majority element.
/// The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
/// </summary>
public class Solution {
    public int MajorityElement(int[] nums) {
        int count = 1;
        int majority = nums[0];
        
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] == majority) count++;
            else {
                count--;
                if(count == 0) {
                    majority = nums[i];
                    count = 1;
                }
            }
        }
        
        return majority;
    }
}