/// <summary>
/// https://leetcode.com/problems/valid-parentheses/
/// </summary>
/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
*/
public class Solution {
    public bool IsValid(string s) {
        if(s.Length <= 1) return false;
        
        Stack<char> helper = new Stack<char>();
        
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '[' || s[i] == '{' || s[i] == '('){
                helper.Push(s[i]);
            }
            else if (s[i] == ']' || s[i] == '}' || s[i] == ')'){
                if(helper.Count == 0) return false;
                
                if(s[i] == ']'){
                    if(helper.Pop() != '[') return false;
                }
                else if(s[i] == '}'){
                    if(helper.Pop() != '{') return false;
                }
                else if(s[i] == ')'){
                    if(helper.Pop() != '(') return false;
                }
            }
            else return false;
        }
        if(helper.Count != 0) return false;
        return true;
    }
}