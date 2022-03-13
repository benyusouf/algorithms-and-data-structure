/// <summary>
/// https://leetcode.com/problems/longest-substring-without-repeating-characters/
/// Given a string s, find the length of the longest substring without repeating characters.
/// </summary>
public class Solution {
    public int LengthOfLongestSubstring(string s)
    {        
        if(string.IsNullOrEmpty(s)) return 0;
        
        HashSet<char> set = new HashSet<char>();
        int start = 0, max = int.MinValue;
        
        for(int end = 0; end < s.Length; end++){
            while(set.Contains(s[end])){
                set.Remove(s[start]);
                start++;
            }
            set.Add(s[end]);
            max = Math.Max(max, end - start +1);
        }
        return max;
    }
}