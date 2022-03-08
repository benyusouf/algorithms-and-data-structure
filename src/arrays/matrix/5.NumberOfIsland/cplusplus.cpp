class Solution {
public:
    
    void dfs(vector<vector<char>> &grid, int i, int j, vector<vector<bool>> &visited){
        
        if(i<0 || j<0 || i>=grid.size() || j>=grid[0].size()){
            return;
        }
        if(grid[i][j] == '0'){
            return;
        }
        if(visited[i][j] == true){
            return;
        }
        
         visited[i][j] = true;
         dfs(grid, i-1, j,   visited);
         dfs(grid, i,   j-1, visited);
         dfs(grid, i,   j+1, visited);
         dfs(grid, i+1, j,   visited);
    }
    
    int numIslands(vector<vector<char>>& grid) {
        int m = grid.size();
        int n = grid[0].size();
        
        vector<vector<bool>> visited(m , vector<bool>(n,false));
        int count = 0;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(grid[i][j] == '1' && visited[i][j] == false){
                    dfs(grid, i, j, visited);
                    count++;
                }
            }
        }
        return count;
    }
};