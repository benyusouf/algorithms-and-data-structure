// https://www.interviewbit.com/problems/find-permutation/
// https://leetcode.com/articles/find-permutation/#
vector<int> Solution::findPerm(const string s, int n) {
      vector<int> ans(n);
      int start = 1, e = n;
      
      for(int i=0;i<s.size();i++){
          if(s[i]=='D'){
              ans[i] = e;
              e--;
          }else{
              ans[i] = start;
              start++;
          }
      }
      ans[n-1] = start; /// e
      return ans;
}
