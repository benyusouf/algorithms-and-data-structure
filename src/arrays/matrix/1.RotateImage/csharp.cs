/// <summary>
/// https://leetcode.com/problems/rotate-image/submissions/
/// </summary>
/*
You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).

You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation.
*/
public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        int m = matrix[0].Length;
        
        for(int row = 0; row < n; row++){
            for(int col = row; col < m; col++){
                Swap(matrix, (row, col), (col, row));
            }
        }
        
        for(int row = 0; row < n; row++){
            Reverse(matrix[row]);
        }
        
    }
    
    void Swap(int[][] matrix, (int, int) a, (int, int) b){
        int temp =  matrix[a.Item1][a.Item2];
        matrix[a.Item1][a.Item2] = matrix[b.Item1][b.Item2];
        matrix[b.Item1][b.Item2] = temp;
    }
    
    void Reverse(int[] a){
        int s = 0, e = a.Length-1;
        
        while(s <= e){
            int temp = a[s];
            a[s] = a[e];
            a[e] = temp;
            
            s++;
            e--;
        }
    }
}