/// https://leetcode.com/problems/search-a-2d-matrix-ii
class Solution {
public:
    bool searchMatrix(vector<vector<int> >& matrix, int target) {
        int rows = matrix.size();
        if(rows==0) return false;
        int cols = matrix[0].size();
        if(cols==0) return false;
        
        if(target<matrix[0][0] || target>matrix[rows-1][cols-1]) return false;
        
        /// top right  
        int i=0;
        int j = cols-1;
        
        while(i<=rows-1 && j>=0){
            if(matrix[i][j] == target) return true;
            else if(matrix[i][j] < target) i++;
            else if(matrix[i][j] > target) j--;
        }
        return false;
    }
};