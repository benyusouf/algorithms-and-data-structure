/*
Given two strings s and p, return an array of all the start indices of p's anagrams in s. You may return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
*/

/// <summary>
/// https://leetcode.com/problems/find-all-anagrams-in-a-string/submissions/
/// </summary>

public class Solution {
    public IList<int> FindAnagrams(string s, string t) {
        IList<int> res = new List<int>();
        
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return res;
        
        Dictionary<char, int> map = new Dictionary<char, int>();
        
        for(int i = 0; i < t.Length; i++){
            if(!map.ContainsKey(t[i]))
                map.Add(t[i], 1);
            else map[t[i]]++;
        }
        
        int start = 0, end = 0, count = map.Count();
        
        while(end < s.Length){
            char endChar = s[end];
            
            if(map.ContainsKey(endChar)){
                map[endChar]--;
                if(map[endChar] == 0) count--;
            }
            
            end++;
            
            while(count == 0){
                
                if(end - start == t.Length){
                    res.Add(start);
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