public class Solution {
    public int LongestCommonSubsequence(string s1, string s2) {
       //  int[,] matrix = new int[s1.Length+1, s2.Length+1];
       // return Longest(s1, s2, 0, 0, matrix); 
        int m = s1.Length, n = s2.Length;
        
        int[,] matrix = new int[m+1, n+1];
        
        
        for(int i = 0; i <=m; i++){
            for(int j = 0; j <=n; j++){
                if(i == 0 || j == 0){
                    matrix[i,j] = 0;
                }
                else if(s1[i-1] == s2[j-1]){
                    matrix[i,j] = 1 + matrix[i-1,j-1];
                }
                else {
                    matrix[i,j] = Math.Max(matrix[i,j-1], matrix[i-1,j]);
                }
            }
        }
        
        return matrix[m,n];
    }
    
//     public int Longest(string s1, string s2, int i, int j, int[,] matrix){
//         if(i == s1.Length || j == s2.Length) return 0;
        
//         if(matrix[i,j] != 0) return matrix[i,j];
        
//         int ans = 0;
        
//         if(s1[i] == s2[j]){
//             ans = 1 + Longest(s1, s2, i+1, j+1, matrix);
//             matrix[i,j] = ans;
//         }
        
//         ans = Math.Max(Longest(s1, s2, i, j+1, matrix), Longest(s1, s2, i+1, j, matrix));
//         matrix[i,j] = ans;
//         return ans;
//     }
}