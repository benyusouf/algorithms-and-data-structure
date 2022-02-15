/// https://leetcode.com/problems/longest-common-prefix/
/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

*/

using System.Linq;

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var ans = string.Empty;
        if(strs.Length < 1) return ans;
        
        var minStr = strs.OrderBy(x => x.Length).First();
        
        for(int i = 0; i < minStr.Length; i++){
            for(int j = 0; j < strs.Length; j++)
                if(minStr[i] != strs[j][i])
                    return ans;
            
            ans += minStr[i];
        }
        
        return ans;
    }
}