/// https://leetcode.com/problems/valid-palindrome-ii/

/// Given a string s, return true if the s can be palindrome after deleting at most one character from it.

public class Solution {
    public bool ValidPalindrome(string s) {
        int b = 0, e = s.Length -1;
        
        while(b <= e){
            //Check and skip non alphanumeric
            while(b < e && !Char.IsLetterOrDigit(s[b])) b++;
            while(b < e && !Char.IsLetterOrDigit(s[e])) e--;
            
            //check if the characters are not equal
            if(!Char.ToLower(s[b]).Equals(Char.ToLower(s[e]))){
                if(Compare(s, b+1, e) || Compare(s, b, e-1)) return true;
                else return false;
            };
            
            b++;
            e--;
        }
        
        return true;
    }
    
    
    bool Compare(string s, int b, int e){
        while(b <= e){
            //check if the characters are not equal
            if(!Char.ToLower(s[b]).Equals(Char.ToLower(s[e]))) return false;
            
            b++;
            e--;
        }
        return true;
    }
}