class Solution {
public:
    struct cell{
        int x;
        int y;
        int time;
    };
    int orangesRotting(vector<vector<int>>& grid) {
        int dx[4] = {0, -1, 1, 0};
        int dy[4] = {-1, 0, 0, 1};
        int m = grid.size();
        int n = grid[0].size();
        vector<vector<bool>> visited(m, vector<bool>(n,false));
        queue<cell> q;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(grid[i][j] == 2){
                    q.push({i,j, 0});
                    visited[i][j] = true;
                }
            }
        }
        int time = 0;
        while(!q.empty()){
            cell t = q.front();
            q.pop();
            time = max(time, t.time);
            for(int i=0;i<4;i++){
                int x = t.x + dx[i];
                int y = t.y + dy[i];
                if(x>=0 && x<m && y>=0 && y<n && grid[x][y] == 1 && !visited[x][y]){
                    q.push({x,y,t.time+1});
                    visited[x][y] = true;
                    grid[x][y] = 2;
                }   
            }
        }
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(grid[i][j] == 1){
                    return -1;
                }
            }
        }
        return time;
    }
};