/// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string-ii/
class Solution {
public:
   
   /* class Pair{
        public:
        char first;   /// character
        int second;    /// count
        Pair(char f,int s){
            first = f;
            second = s;
        }
    };
    string removeDuplicates(string A, int k) {
        
        stack<Pair> s;
        
    inbuilt pair class
         for(int i=0;i<A.size();i++){
             if(s.empty() || A[i] != s.top().first){
                 /// push a pair
                 Pair p(A[i],1); 
                 s.push(p);
             } else {
                 /// A[i] = top element 
                 s.top().second++;
                 int count = s.top().second;
                 if(count==k){
                     s.pop();
                 }
                 
             }
         }
        
        string ans="";
        while(!s.empty()){
            int count = s.top().second;
            while(count--){
                 ans.push_back(s.top().first);
            }
            s.pop();
        }
        
        reverse(ans.begin(),ans.end());
        return ans;
        */
    
    /// inbuilt pair class
    
     string removeDuplicates(string A, int k) {
        
        stack<pair<char,int> > s;
         for(int i=0;i<A.size();i++){
             if(s.empty() || A[i] != s.top().first){
                 /// push a pair
                // pair p = {A[i],1};
                 pair p(A[i],1);
                 s.push(p);
                 //s.push(make_pair(A[i],1));
             } else {
                 /// A[i] = top element 
                 s.top().second++;
                 int count = s.top().second;
                 if(count==k){
                     s.pop();
                 }
                 
             }
         }
        
        string ans="";
        while(!s.empty()){
            int count = s.top().second;
            while(count--){
                 ans.push_back(s.top().first);
            }
            s.pop();
        }
        
        reverse(ans.begin(),ans.end());
        return ans;
    
    }
};