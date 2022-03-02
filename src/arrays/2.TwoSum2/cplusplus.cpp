/// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
class Solution {
public:
    vector<int> twoSum(vector<int>& A, int target) {
        vector<int> ans;
        
        int s = 0;
        int e = A.size()-1;
        
        while(s<e){
            if(A[s] + A[e] == target){
                ans.push_back(s+1);
                ans.push_back(e+1);
                return ans;
            }else if(A[s] + A[e] < target){
                s++;
            }else{
                e--;
            }
        }
        return ans;
    }
};