/// https://leetcode.com/problems/excel-sheet-column-number/
/*
Given a string columnTitle that represents the column title as appear in an Excel sheet, return its corresponding column number.
*/

public class Solution {
    public int TitleToNumber(string columnTitle) {
        int result = 0, power = 1;
        
        for(int i = columnTitle.Length - 1; i >= 0; i--){
            result += (columnTitle[i] - 64) * power;
            power *= 26;
        }
        
        return result;
    }
}