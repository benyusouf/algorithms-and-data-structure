/// https://leetcode.com/problems/valid-palindrome/

/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and 
removing all non-alphanumeric characters, it reads the same forward and backward. 
Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.
*/

public class Solution {
    public bool IsPalindrome(string s) {
        int b = 0, e = s.Length -1;
        
        while(b <= e){
            //Check and skip non alphanumeric
            while(b < e && !Char.IsLetterOrDigit(s[b])) b++;
            while(b < e && !Char.IsLetterOrDigit(s[e])) e--;
            
            //check if the characters are not equal
            if(!Char.ToLower(s[b]).Equals(Char.ToLower(s[e]))) return false;
            
            b++;
            e--;
        }
        
        return true;
    }
}