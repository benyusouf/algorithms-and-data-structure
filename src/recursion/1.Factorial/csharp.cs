
public class Solution {
    public long Factorial(int n) {
        if(n < 0) return -1;
        if(n == 0) return 1;
        return n * Factorial(n-1);
    }
    
}