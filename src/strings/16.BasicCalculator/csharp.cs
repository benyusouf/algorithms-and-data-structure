/*
Given a string s which represents an expression, evaluate this expression and return its value. 

The integer division should truncate toward zero.

You may assume that the given expression is always valid. All intermediate results will be in the range of [-231, 231 - 1].

Note: You are not allowed to use any built-in function which evaluates strings as mathematical expressions, such as eval().
*/

/// <summary>
/// https://leetcode.com/problems/basic-calculator-ii/
/// </summary>
public class Solution {
    public int Calculate(string s) {
        var stack = new Stack<int>();
        
        char op = '+';
        int num = 0;
        
        for (int i = 0; i <= s.Length; i++)
        {
            char c = i < s.Length ? s[i] : '+';
            
            if (c == ' ') continue;
            
            if (char.IsNumber(c))
            {
                num = num * 10 + (c - '0');
            }
            else
            {
                if (op == '+') stack.Push(num);
                if (op == '-') stack.Push(-num);
                if (op == '*') stack.Push(stack.Pop() * num);
                if (op == '/') stack.Push(stack.Pop() / num);
                
                op = c;
                
                num = 0;
            }
        }
        
        return stack.Sum();
    }
}