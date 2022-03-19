/*
Given an integer array nums, find a contiguous non-empty subarray within the array that has the largest product, and return the product.

The test cases are generated so that the answer will fit in a 32-bit integer.

A subarray is a contiguous subsequence of the array.
*/
/// <summary>
/// https://leetcode.com/problems/maximum-product-subarray/submissions/
/// </summary>
public class Solution {
    public int MaxProduct(int[] nums) {
//         int product = int.MinValue, curProd = 1;
        
//         for(int i = 0; i < nums.Length; i++){
//             curProd *= nums[i];
//             product = Math.Max(product, curProd);
            
//             if(curProd == 0) curProd = 1;
//         }
//         curProd = 1;
//         for(int i = nums.Length - 1; i >= 0; i--){
//             curProd *= nums[i];
//             product = Math.Max(product, curProd);
            
//             if(curProd == 0) curProd = 1;
//         }
//         return product;
        int product = int.MinValue, leftProd = 1, rightProd = 1;
        
        for(int i = 0; i < nums.Length; i++){
            leftProd *= nums[i];
            rightProd *=  nums[nums.Length - 1 - i];
            product = Math.Max(product, Math.Max(leftProd, rightProd));
            if(leftProd == 0) leftProd = 1;
            if(rightProd == 0) rightProd = 1;
        }
        
        return product;
    }
}