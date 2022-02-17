
public class Solution {
    public int Power(int n, int m) {
        if(m == 1) return n;
        if(m == 0) return 1;

        return n * Power(m-1);
    }
    
}