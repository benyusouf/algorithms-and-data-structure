public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        if(grid[0][0] != 0) return -1;
        
        int[] dx = new int[8]{-1,0,1,-1,1,-1,0,1};
        int[] dy = new int[8]{-1,-1,-1,0,0,1,1,1};
        int m = grid.Length, n = grid[0].Length;
        
        bool[,] visited = new bool[m,n];
        
        Queue<Cell> q = new Queue<Cell>();
        
        q.Enqueue(new Cell(0,0,1));
        visited[0,0] = true;
        
        while(q.Count() > 0){
            Cell front = q.Dequeue();
            if(front.X == n-1 && front.Y == m-1)
                return front.D;
            for(int i = 0; i < 8; i++){
                int y = front.Y + dy[i];
                int x = front.X + dx[i];
                int d = front.D + 1;
                
                if(y >= 0 && y < n && x >= 0 && x < m
                  && grid[x][y] == 0 && visited[x,y] == false){
                    q.Enqueue(new Cell(x,y,d));
                    visited[x,y] = true;
                }
            }
        }
        
        return -1;
    }
}

public class Cell{
    public Cell(int x, int y, int d){
        X = x;
        Y = y;
        D = d;
    }
    public int X {get; set;}
    public int Y {get; set;}
    public int D {get; set;}
}