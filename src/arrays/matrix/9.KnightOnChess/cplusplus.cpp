 struct cell{
        int x;
        int y;
        int moves;
    };
int Solution::knight(int m, int n, int sx, int sy, int tx, int ty) {
        int dx[8] = {-2, -1, 1, 2, -2, -1, 1, 2};
        int dy[8] = {-1, -2, -2, -1, 1, 2, 2, 1};
        vector<vector<bool>> visited(m+1, vector<bool>(n+1,false));
        queue<cell> q;
        q.push({sx,sy,0});
        visited[sx][sy] = true;
        
        while(!q.empty()){
            cell t = q.front();
            q.pop();
            if(t.x == tx && t.y == ty){
                return t.moves;
            }
            for(int i=0;i<8;i++){
                int x = t.x + dx[i];
                int y = t.y + dy[i];
                if(x>=1 && x<=m && y>=1 && y<=n && !visited[x][y]){
                    q.push({x,y,t.moves+1});
                    visited[x][y] = true;
                }
            }
        }
        return -1;
}
