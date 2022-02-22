/// <summary>
/// https://leetcode.com/problems/zigzag-conversion/
/// </summary>
/*
The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
A P L S I I G
Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows:
*/
public class Solution {
    public string Convert(string s, int n) {
        if(n <= 1) return s;
        
        int l = s.Length;
        string[] a = new string[n];
        int row = 0;
        int down = 1;
        
        foreach(char c in s){
            a[row] += c;
            
            if(row == 0) down = 1;
            else if(row == n - 1) down = -1;
            
            row += down;
        }
        
        string ans = "";
        
        foreach(string str in a){
            ans += str;
        }
        
        return ans;
    }
}