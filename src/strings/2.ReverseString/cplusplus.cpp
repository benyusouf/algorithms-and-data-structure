/// https://leetcode.com/problems/reverse-string/
class Solution {
public
    void reverseString(vectorchar& A) {
        stackchar st;
        for(int i=0;iA.size();i++){
             pushing every char inside stack
            st.push(A[i]);
        }
        
         pop every character
        for(int i=0;iA.size();i++){
            A[i] = st.top();
            st.pop();
        }
        
        
        int s=0;
        int e = A.size()-1;
        
        while(s=e){
            swap(A[s],A[e]);
            s++;
            e--;
        }
        
        reverse(A.begin(),A.end());
        
        
    }