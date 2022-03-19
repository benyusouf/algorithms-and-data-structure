/*
Given a string s of '(' , ')' and lowercase English characters.

Your task is to remove the minimum number of parentheses ( '(' or ')', in any positions ) so that the resulting parentheses string is valid and return any valid string.

Formally, a parentheses string is valid if and only if:

It is the empty string, contains only lowercase characters, or
It can be written as AB (A concatenated with B), where A and B are valid strings, or
It can be written as (A), where A is a valid string.
*/

/// <summary>
/// https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses/submissions/
/// </summary>
public class Solution {
    public string MinRemoveToMakeValid(string s) {
//         int open = 0;
//         string helper = "";
        
//         foreach(char c in s){
//             if(c == '('){
//                 open++;
//             }
//             else if(c == ')'){
//                 if(open == 0) continue;
//                 open--;
//             }
//             helper += c;
//         }
        
//         string result = "";
        
//         for(int i = helper.Length - 1; i >= 0; i--){
//             if(helper[i] == '(' && open > 0){
//                 open--;
//                 continue;
//             }
//             result = $"{helper[i]}{result}";
//         }
        
//         return result;
        
//         Stack<int> st = new Stack<int>();
//         char[] sArray = s.ToCharArray();
//         for(int i = 0; i < s.Length; i++){
//             if(s[i] == '('){
//                 st.Push(i);
//             }
//             else if(s[i] == ')'){
//                 if(st.Count() == 0){
//                     sArray[i] = '*';
//                     continue;
//                 }
//                 st.Pop();
//             }
//         }
        
//         while(st.Count() > 0){
//             sArray[st.Pop()] = '*';
//         }
//         string result = "";
//         foreach(char c in sArray){
//             if(c != '*') 
//                 result += c;
//         }
        
//         return result;
        
        StringBuilder builder = new StringBuilder(s);
        
            Stack<(char, int)> stack = new Stack<(char, int)>();

            for (int i = 0; i < s.Length; i++)
                if (stack.Count() > 0 && stack.Peek().Item1 == '(' && s[i] == ')')
                    stack.Pop();
                else if (s[i] == '(' || s[i] == ')')
                    stack.Push((s[i], i));

            while (stack.Count > 0)
                builder.Remove(stack.Pop().Item2, 1);

            return builder.ToString();
    }
}