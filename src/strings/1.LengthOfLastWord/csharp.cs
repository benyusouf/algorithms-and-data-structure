/// https://leetcode.com/problems/length-of-last-word/
public class Solution {
    public int LengthOfLastWord(string s) {
        int n = s.Length, i = 0, count = 0;
        
        while(i < n){
            if(s[i] != ' '){
                count++;
                i++;
            }
            else {
                //If char at i is space and we're not out of the loop then we move ahead
                while(i < n && s[i] == ' ') i++;
                // return if we reach the end of the string
                if(i == n) return count;
                //otherwise reset count to zero
                else count = 0;
            }
        }
        return count;
    }
}