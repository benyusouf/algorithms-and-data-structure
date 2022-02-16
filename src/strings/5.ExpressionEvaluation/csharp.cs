/// https://leetcode.com/problems/evaluate-reverse-polish-notation/
/*
Evaluate the value of an arithmetic expression in Reverse Polish Notation.

Valid operators are +, -, *, and /. Each operand may be an integer or another expression.

Note that division between two integers should truncate toward zero.

It is guaranteed that the given RPN expression is always valid. That means the expression would always evaluate to a result, and there will not be any division by zero operation.
*/
public class Solution {
    public int EvalRPN(string[] tokens) {
        var helper = new Stack<int>();
        
        for(int i = 0; i < tokens.Length; i++){
            if(tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/"){
                var second = helper.Pop();
                var first = helper.Pop();
                if(tokens[i] == "+"){
                    helper.Push(first+second);
                }
                else if(tokens[i] == "-"){
                    helper.Push(first-second);
                }
                else if(tokens[i] == "*"){
                    helper.Push(first*second);
                }
                else if(tokens[i] == "/"){
                    helper.Push(first/second);
                }
            }
            else{
                helper.Push(Convert.ToInt32(tokens[i]));
            }
        }
        
        return helper.Pop();
    }
}