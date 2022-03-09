public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        
        int area = 0;
        
        bool[,] visited = new bool[m,n];
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 1 && !visited[i,j]){
                    int result = Dfs(grid, visited, i, j);
                    area = Math.Max(area, result);
                }
            }
        }
        
        return area;
    }
    
    public int Dfs(int[][] grid, bool[,] visited, int i, int j){
        if(grid == null || grid.Length == 0) return 0;
        if(i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length) return 0;
        
        if(grid[i][j] == 0) return 0;
        if(visited[i,j]) return 0;
        
        visited[i,j] = true;
        
        return 1 + Dfs(grid, visited, i, j-1)
                 + Dfs(grid, visited, i, j+1)
                 + Dfs(grid, visited, i-1, j)
                 + Dfs(grid, visited, i+1, j);
    }
}