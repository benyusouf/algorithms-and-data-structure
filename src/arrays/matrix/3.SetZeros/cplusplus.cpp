//https://leetcode.com/problems/set-matrix-zeroes/
class Solution {
public:
    void setZeroes(vector<vector<int> >& matrix) {
        int rownum = matrix.size();
        if(rownum==0) return;
        int colnum = matrix[0].size();
        if(colnum==0) return;
        
        bool hasZeroFirstRow = false;
        bool hasZeroFirstCol = false;
        
        /// Does first Row have ZERO element ?
        for(int j=0;j<colnum;j++){
            if(matrix[0][j] == 0){
                hasZeroFirstRow = true;
                break;
            }
        }
        /// Does first Col have ZERO element ?
        for(int j=0;j<rownum;j++){
            if(matrix[j][0] == 0){
                hasZeroFirstCol = true;
                break;
            }
        }
        
        /// make use of first rown and col
        /// find zero and store info in first row and col
        for(int i=1;i<rownum;i++){
            for(int j=1;j<colnum;j++){
                if(matrix[i][j] == 0){
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }
        
        for(int i=1;i<rownum;i++){
            for(int j=1;j<colnum;j++){
                if(matrix[0][j]==0 || matrix[i][0]==0){
                    matrix[i][j] = 0;
                }
            }
        }
        
        /// set zeroes for first row
        if(hasZeroFirstRow){
            for(int i=0;i<colnum;i++){
                matrix[0][i] = 0;
            }
        }
        
        /// set zeroes for first col
        if(hasZeroFirstCol){
            for(int i=0;i<rownum;i++){
                matrix[i][0] = 0;
            }
        }
    }
};