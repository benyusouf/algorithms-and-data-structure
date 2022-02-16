/// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
/// https://www.hackerrank.com/challenges/reduced-string/problem
/*
You are given a string s consisting of lowercase English letters. A duplicate removal consists of choosing two adjacent and equal letters and removing them.

We repeatedly make duplicate removals on s until we no longer can.

Return the final string after all such duplicate removals have been made. It can be proven that the answer is unique.
*/
public class Solution {
    /// <summary>
    /// Using a stack
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string RemoveDuplicates(string s) {
        var helper = new Stack<char>();
        var result = string.Empty;
        
        for(int i = 0; i < s.Length; i++){
            if(helper.Count == 0) helper.Push(s[i]);
            else if(helper.Peek() == s[i]) helper.Pop();
            else helper.Push(s[i]);
        }
        
        while(helper.Count != 0){
            result = $"{helper.Pop()}{result}";
        }
        return result;
    }


/// <summary>
/// Using a pointer
/// </summary>
/// <param name="s"></param>
/// <returns></returns>
    public string RemoveDuplicates2(string s){
        var result = string.Empty;
        var p = -1;
        
        for(int i = 0; i < s.Length; i++){
            if(p == -1 || s[i] != s[p]) {
                p++;
                s= s.Remove(p, 1).Insert(p, s[i].ToString());
            }
            else p--;
        }
        
        if(p == -1) return "Empty String";
        
        for(int i = 0; i <= p; i++){
            result += s[i];
        }
        return result;
    }



}