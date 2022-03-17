public class Solution {
    public bool Exist(char[][] board, string word) {
        int m = board.Length, n = board[0].Length;
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if (Dfs(board, i, j, word, 0))
                    return true;
            }
        }
        return false;
    }
    
    bool Dfs(char[][] board, int i, int j, string word, int index){
        if(index == word.Length) return true;
        
        if(i < 0 || i >= board.Length || j < 0 || j >= board[0].Length)
            return false;
        
        if(word[index] != board[i][j]) return false;
        board[i][j] = '*';
        
        bool deepSearch =
            Dfs(board, i, j-1, word, index+1) ||
            Dfs(board, i-1, j, word, index+1) ||
            Dfs(board, i, j+1, word, index+1) ||
            Dfs(board, i+1, j, word, index+1);
        
        board[i][j] = word[index];
        
        return deepSearch;
    }
}