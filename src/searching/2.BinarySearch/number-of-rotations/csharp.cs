public class Solution {
    public int FindMin(int[] a) {
        int s = 0, n = a.Length;
        int e = n-1;
        
        while(s <= e){
            int m = s + (e-s)/2;
            int next = (m+1)%n, prev = (m-1+n)%n;
            
            if(a[m] <= a[next] && a[m] <= a[prev]) return m;
            else if(a[m] <= a[e]){
                e = m-1;
            }
            else if(a[m] >= a[s]){
                s = m +1;
            }
        }
        
        return -1;
    }
}