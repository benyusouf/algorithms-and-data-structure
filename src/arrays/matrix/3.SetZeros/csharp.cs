/// <summary>
/// https://leetcode.com/problems/set-matrix-zeroes/
/// </summary>
/*

Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's.

You must do it in place.

*/
public class Solution {
    public void SetZeroes(int[][] matrix) {
        bool hasZeroFirstColumn = false, hasZeroFirstRow = false;
        int m = matrix.Length, n = matrix[0].Length;
        
        if(m == 0) return;
        
        for(int i = 0; i < m; i++){
            if(matrix[i][0] == 0){
                hasZeroFirstRow = true;
                break;
            }
        }
        
        for(int i = 0; i < n; i++){
            if(matrix[0][i] == 0){
                hasZeroFirstColumn = true;
                break;
            }
        }
        
        for(int i = 1; i < m; i++){
            for(int j = 1; j < n; j++){
                if(matrix[i][j] == 0){
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }
        
        for(int i = 1; i < m; i++){
            for(int j = 1; j < n; j++){
                if(matrix[i][0] == 0 || matrix[0][j] == 0){
                    matrix[i][j] = 0;    
                }
            }
        }
        
        if(hasZeroFirstRow){
            for(int i = 0; i < m; i++){
            matrix[i][0] = 0;
            }
        }
        
        if(hasZeroFirstColumn){
            for(int i = 0; i < n; i++){
            matrix[0][i] = 0;
            }
        }
        
    }
}