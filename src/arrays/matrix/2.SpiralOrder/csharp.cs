/// <summary>
/// https://leetcode.com/problems/spiral-matrix/
/// </summary>
/*
Given an m x n matrix, return all elements of the matrix in spiral order.
*/

public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        int m = matrix.Length, n = matrix[0].Length;
        IList<int> ans = new List<int>(m*n);
        
        if(m == 0) return ans;
        
        int sr = 0, er = m-1, sc = 0, ec = n-1, count = 0;
        
        while(sr <= er && sc <= ec){
            for(int i = sc; i <= ec; i++){
                ans.Add(matrix[sr][i]);
                count++;
            }
            sr++;
            if(count == m*n) return ans;
            
            for(int i = sr; i <= er; i++){
                ans.Add(matrix[i][ec]);
                count++;
            }
            ec--;
            if(count == m*n) return ans;
            
            for(int i = ec; i >= sc; i--){
                ans.Add(matrix[er][i]);
                count++;
            }
            er--;
            if(count == m*n) return ans;
            
            for(int i = er; i >= sr; i--){
                ans.Add(matrix[i][sc]);
                count++;
            }
            sc++;
            if(count == m*n) return ans;
        }
        
        return ans;
    }
}