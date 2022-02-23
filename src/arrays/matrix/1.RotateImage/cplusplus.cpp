/// https://leetcode.com/problems/rotate-image/
class Solution {
public:
    void rotate(vector<vector<int> >& matrix) {
        int m = matrix.size();
        int n = matrix[0].size();
        
        /// Transpose
        /// swap rows and cols
        for(int row = 0;row<m;row++){
            for(int col = row;col<n;col++){
                swap(matrix[row][col] , matrix[col][row]);
            }
        }
        
        /// Reverse each row 
        for(int row=0;row<m;row++){
            int s = 0, e = n-1;
            while(s<=e){
                swap(matrix[row][s], matrix[row][e]);
                s++;
                e--;
            }
        }
        
    }
};