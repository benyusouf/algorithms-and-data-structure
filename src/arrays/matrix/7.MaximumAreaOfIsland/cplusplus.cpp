class Solution {
public:
    
    void dfs(vector<vector<int>> &grid, int i, int j, vector<vector<bool>> &visited, int &area){
        
        if(i<0 || j<0 || i>=grid.size() || j>=grid[0].size()){
            return;
        }
        if(grid[i][j] == 0){
            return;
        }
        if(visited[i][j] == true){
            return;
        }
        
         visited[i][j] = true;
         area++;
         dfs(grid, i-1, j,   visited, area);
         dfs(grid, i,   j-1, visited, area);
         dfs(grid, i,   j+1, visited, area);
         dfs(grid, i+1, j,   visited, area);
    }
    
    int maxAreaOfIsland(vector<vector<int>>& grid) {
        int m = grid.size();
        int n = grid[0].size();
        
        vector<vector<bool>> visited(m , vector<bool>(n,false));
        int maxArea = 0;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(grid[i][j] == 1 && visited[i][j] == false){
                    int area = 0;
                    dfs(grid, i, j, visited, area);
                    maxArea = max(maxArea, area);
                }
            }
        }
        return maxArea;
    }
};