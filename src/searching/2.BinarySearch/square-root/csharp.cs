/// <summary>
/// https://leetcode.com/problems/sqrtx/
/// </summary>
/*
Given a non-negative integer x, compute and return the square root of x.

Since the return type is an integer, the decimal digits are truncated, and only the integer part of the result is returned.

Note: You are not allowed to use any built-in exponent function or operator, such as pow(x, 0.5) or x ** 0.5.
*/
public class Solution {
    public int MySqrt(int x) {
        if(x == 0) return 0;
        int s = 1, e = x, ans = 0;
        
        while(s <= e){
            int m = s + (e-s)/2;
            
            if(m == x/m) return m;
            else if(m < x/m){
                ans = m;
                s = m + 1;
            }
            else{
                e = m - 1;
            }
        }
        return ans;
    }
    
}