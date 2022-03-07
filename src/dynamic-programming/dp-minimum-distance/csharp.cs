public class Solution {
    public int MinDistance(string s1, string s2) {
        // return MinDis(s1, s2, s1.Length, s2.Length);
        int m = s1.Length, n = s2.Length;
        
        if(m == 0) return n;
        if(n == 0) return m;
        
        int[,] matrix = new int[m+1,n+1];
        
        for(int i = 0; i <= m; i++){
            for(int j = 0; j <= n; j++){
                if(i == 0)
                    matrix[i,j] = j;
                else if(j == 0)
                    matrix[i,j] = i;
                else if(s1[i-1] == s2[j-1]){
                    matrix[i,j] = matrix[i-1,j-1];
                }
                else{
                    int insert = matrix[i, j-1], del = matrix[i-1,j], rep = matrix[i-1,j-1];
                    
                    matrix[i,j] = 1 + Math.Min(insert, Math.Min(del, rep));
                }
            }
        }
        
        return matrix[m,n];
    }
    
//     public int MinDis(string s1, string s2, int m, int n){
//         if(m == 0) return n;
//         if(n == 0) return m;
        
//         if(s1[m-1] == s2[n-1])
//             return MinDis(s1, s2, m-1, n-1);
        
//         int i = MinDis(s1, s2, m, n-1);
//         int d = MinDis(s1, s2, m-1, n);
//         int r = MinDis(s1, s2, m-1, n-1);
        
//         return 1 + Math.Min(i, Math.Min(d, r));
//     }
}