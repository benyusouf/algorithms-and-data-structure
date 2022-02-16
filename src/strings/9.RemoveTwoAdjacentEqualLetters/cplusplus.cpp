/// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
/// https://www.hackerrank.com/challenges/reduced-string/problem
class Solution {
public:
    string removeDuplicates(string A) {
         /*stack<char> s;
         for(int i=0;i<A.size();i++){
             if(s.empty() || A[i] != s.top()){
                 s.push(A[i]);
             } else {
                 s.pop();
             }
         }
        string ans="";
        while(!s.empty()){
            ans.push_back(s.top());
            s.pop();
        }
        
        reverse(ans.begin(),ans.end());
        return ans;
        */
        
        /// simulate inplace stack
        int stptr = -1;
        for(int i=0;i<A.size();i++){
             if(stptr ==-1 || A[i] != A[stptr] ){
                 stptr++;
                 A[stptr] = A[i];
             } else {
                 stptr--;
             }
         }
         string ans="";
        for(int i=0;i<=stptr;i++){
            ans.push_back(A[i]);
        }
        return ans;
    }
};