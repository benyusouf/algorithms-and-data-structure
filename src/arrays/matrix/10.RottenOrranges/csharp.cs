/*
You are given an m x n grid where each cell can have one of three values:

0 representing an empty cell,
1 representing a fresh orange, or
2 representing a rotten orange.
Every minute, any fresh orange that is 4-directionally adjacent to a rotten orange becomes rotten.

Return the minimum number of minutes that must elapse until no cell has a fresh orange. If this is impossible, return -1.
*/

/// <summary>
/// https://leetcode.com/problems/rotting-oranges/
/// </summary>
public class Solution {
    public int OrangesRotting(int[][] grid) {
        int[] dx = new int[4] {0,-1,0,1};
        int[] dy = new int[4] {-1,0,1,0};
        
        int m = grid.Length, n = grid[0].Length;
        
        bool[,] visited = new bool[m,n];
        
        Queue<Cell> q = new Queue<Cell>();
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 2){
                    q.Enqueue(new Cell(i,j,0));
                    visited[i,j] = true;
                }
            }
        }
        int time = 0;
        while(q.Count() > 0){
            Cell front = q.Dequeue();
            time = Math.Max(time, front.T);
            
            for(int i = 0; i < 4; i++){
                int x = front.X + dx[i];
                int y = front.Y + dy[i];
                int t = front.T + 1;
            
                if(x >= 0 && x < m && y >= 0 && y < n && grid[x][y] == 1 && !visited[x,y]){
                    q.Enqueue(new Cell(x,y,t));
                    grid[x][y] = 2;
                    visited[x,y] = true;
                }
            }
        }
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 1){
                    return -1;
                }
            }
        }
        
        return time;
    }
}

public struct Cell{
    public Cell(int x, int y, int t){
        X = x;
        Y = y;
        T = t;
    }
    
    public int X {get; set;}
    public int Y {get; set;}
    public int T {get; set;}
}