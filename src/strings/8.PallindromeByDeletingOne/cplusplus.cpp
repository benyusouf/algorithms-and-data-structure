/// https://leetcode.com/problems/valid-palindrome-ii/
class Solution {
public:
    
    bool check(string A,int s,int e){
        while(s<=e){
            if(A[s] != A[e]){
                return false;
            }
            s++;
            e--;
        }
        return true;
    }
    
    bool validPalindrome(string A) {
        int s=0;
        int e = A.size()-1;
        
        while(s<=e){
            if(A[s] != A[e]){
                /// 2 cases
                /// delete s  check for A[s+1...e]
                /// delete e check for A[s...e-1]
                if(check(A,s+1,e) || check(A,s,e-1)){
                    return true;
                } else {
                    /// after deleting 1 char we are unable to obtain a palin
                    return false;
                }
                
            }
            s++;
            e--;
        }
        
        /// string is already palin
        return true;
    }
};