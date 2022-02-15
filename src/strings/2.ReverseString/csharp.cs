/// https://leetcode.com/problems/reverse-string/
/* 
Write a function that reverses a string. The input string is given as an array of characters s.

You must do this by modifying the input array in-place with O(1) extra memory.
*/
public class Solution {
    //Using a helper stack
        public void ReverseString(char[] s) {
            Stack<char> helperStack = new Stack<char>();
            
            for(int i = 0; i < s.Length; i++){
                helperStack.Push(s[i]);
            }
            for(int i = 0; i < s.Length; i++){
                s[i] = helperStack.Pop();
            }
        }
        // Using two pointers & swapping
        public void ReverseString2(char[] str) {        
        int s = 0, e = str.Length-1; 
        
        while(s < e){
            char temp = str[s];
            str[s] = str[e];
            str[e] = temp;
            
            s++;
            e--;
        }
    }
}