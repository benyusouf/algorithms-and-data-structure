/// <summary>
/// https://leetcode.com/problems/search-a-2d-matrix-ii/
/// </summary>
/*
Write an efficient algorithm that searches for a value target in an m x n integer matrix matrix. This matrix has the following properties:

Integers in each row are sorted in ascending from left to right.
Integers in each column are sorted in ascending from top to bottom.
*/
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length, n = matrix[0].Length;
        if(m == 0) return false;
        if(target < matrix[0][0] || target > matrix[m-1][n-1]) return false;
        
        int row = 0, col = n-1;
        
        while(row < m && col >= 0){
            if(matrix[row][col] == target) return true;
            else if (matrix[row][col] > target) col--;
            else  row++;
        }
        
        return false;
    }
}