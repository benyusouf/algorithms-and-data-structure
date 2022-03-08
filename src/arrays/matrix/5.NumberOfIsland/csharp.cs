public class Solution {
    public int NumIslands(char[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        
        bool[,] visited = new bool[m,n];
        int count = 0;
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == '1' && !visited[i,j]){
                    Dfs(grid, visited, i, j);
                    count++;
                }
            }
        }
        return count;
    }
    
    public void Dfs(char[][] grid, bool[,] visited, int i, int j){
        if(grid == null || grid.Length == 0) return;
        if(i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length) return;
        
        if(grid[i][j] == '0') return;
        if(visited[i,j]) return;
        
        visited[i,j] = true;
        
        Dfs(grid, visited, i, j-1);
        Dfs(grid, visited, i, j+1);
        Dfs(grid, visited, i-1, j);
        Dfs(grid, visited, i+1, j);
    }
}