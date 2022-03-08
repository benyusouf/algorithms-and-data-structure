public class Solution {
    public void Solve(char[][] board) {
        int m = board.Length, n = board[0].Length;
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(i == 0 || i == m-1 || j == 0 || j == n-1 && board[i][j] == 'O'){
                    Dfs(board, i, j);
                }
            }
        }
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(board[i][j] == 'O'){
                    board[i][j] = 'X';
                }
                else if(board[i][j] == '#'){
                    board[i][j] = 'O';
                }
            }
        }
    }
    
    public void Dfs(char[][] board, int i, int j){
        if(i < 0 || j < 0 || i >= board.Length || j >= board[0].Length || board[i][j]=='X' || board[i][j] == '#') 
            return;
        
        board[i][j] = '#';
        
        Dfs(board, i, j-1);
        Dfs(board, i, j+1);
        Dfs(board, i-1, j);
        Dfs(board, i+1, j);
        
    }
}