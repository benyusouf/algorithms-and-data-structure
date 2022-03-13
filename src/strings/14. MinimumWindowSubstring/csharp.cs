/*
Given two strings s and t of lengths m and n respectively, return the minimum window substring of s such that every character in t (including duplicates) is included in the window. If there is no such substring, return the empty string "".

The testcases will be generated such that the answer is unique.

A substring is a contiguous sequence of characters within the string.
*/

/// <summary>
/// https://leetcode.com/problems/minimum-window-substring/
/// </summary>
public class Solution {
    public string MinWindow(string s, string t) {
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return "";
        Dictionary<char, int> map = new Dictionary<char, int>();
        
        for(int i = 0; i < t.Length; i++){
            if(!map.ContainsKey(t[i]))
                map.Add(t[i], 1);
            else map[t[i]]++;
        }
        
        int start = 0, end = 0, min = s.Length + 1, count = map.Count();
        string res = "";
        
        while(end < s.Length){
            char endChar = s[end];
            
            if(map.ContainsKey(endChar)){
                map[endChar]--;
                if(map[endChar] == 0) count--;
            }
            
            end++;
            
            while(count == 0){
                
                if(end - start < min){
                    min = end - start;
                    res = s.Substring(start, min);
                }
                
                char startChar = s[start];
            
                if(map.ContainsKey(startChar)){
                    map[startChar]++;
                    if(map[startChar] > 0) count++;
                }
                
                start++;
            }
        }
        
        return res;
    }
}



