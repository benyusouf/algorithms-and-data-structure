/*
You are given an n x n binary matrix grid. You are allowed to change at most one 0 to be 1.

Return the size of the largest island in grid after applying this operation.

An island is a 4-directionally connected group of 1s.
*/
/// <summary>
/// https://leetcode.com/problems/making-a-large-island/submissions/
/// </summary>
public class Solution {
    public int LargestIsland(int[][] grid) {
        int n = grid.Length;
        
        int[] areas = new int[n*n + 2];
        int color = 2;
        
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 1){
                    areas[color] = Dfs(grid, i, j, color);
                    color++;
                }
            }
        }
        
        bool hasWater = false;
        
        int largestArea = int.MinValue;
        
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 0){
                    hasWater = true;
                    HashSet<int> set = new HashSet<int>();
                    if(i > 0) set.Add(grid[i-1][j]);
                    if(j > 0) set.Add(grid[i][j-1]);
                    if(i < n-1) set.Add(grid[i+1][j]);
                    if(j < n-1) set.Add(grid[i][j+1]);
                    
                    int area = 1;
                    
                    foreach(int num in set)
                        area += areas[num];
                    
                    largestArea = Math.Max(largestArea, area);
                }
            }
        }
        
        return hasWater ? largestArea : n * n;
    }
    
    int Dfs(int[][] grid, int i, int j, int color){
        if(i < 0 || j < 0 || i >= grid.Length || j >= grid.Length || grid[i][j] != 1)
            return 0;
        grid[i][j] = color;
        
        return 1 + 
            Dfs(grid, i, j-1, color) + 
            Dfs(grid, i, j+1, color) + 
            Dfs(grid, i-1, j, color) + 
            Dfs(grid, i+1, j, color);
    }
}