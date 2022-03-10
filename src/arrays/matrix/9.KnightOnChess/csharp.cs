/*
Given any source point, (C, D) and destination point, (E, F) on a chess board, we need to find whether Knight can move to the destination or not.
If yes, then what would be the minimum number of steps for the knight to move to the said point.

If knight can not move from the source point to the destination point, then return -1.

Note: A knight cannot go out of the board.
*/

/// <summary>
/// https://www.interviewbit.com/problems/knight-on-chess-board/
/// </summary>
class Solution {
    public int knight(int m, int n, int sx, int sy, int tx, int ty) {
        int[] dx = new int[8]{-2, -1, 1, 2, -2, -1, 1, 2};
        int[] dy = new int[8]{-1, -2, -2, -1, 1, 2, 2, 1};
        
        bool[,] visited = new bool[m+1,n+1];
        
        Queue<Cell> q = new Queue<Cell>();
        
        q.Enqueue(new Cell(sx,sy,0));
        visited[sx,sy] = true;
        
        while(q.Count() > 0){
            Cell front = q.Dequeue();
            if(front.X == tx && front.Y == ty)
                return front.M;
            for(int i = 0; i < 8; i++){
                int y = front.Y + dy[i];
                int x = front.X + dx[i];
                int d = front.M + 1;
                
                if(y >= 1 && y <= n && x >= 1 && x <= m
                   && visited[x,y] == false){
                    q.Enqueue(new Cell(x,y,d));
                    visited[x,y] = true;
                }
            }
        }
        
        return -1;
    }
}

public class Cell{
    public Cell(int x, int y, int m){
        X = x;
        Y = y;
        M = m;
    }
    public int X {get; set;}
    public int Y {get; set;}
    public int M {get; set;}
}
