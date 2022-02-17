/// <summary>
/// https://leetcode.com/problems/factorial-trailing-zeroes/
/// Given an integer n, return the number of trailing zeroes in n!
/// </summary>
public class Solution {
    public int TrailingZeroes(int n) {
        return n/5 + n/25 + n/125 + n/625 + n/3125;
    }
    
}