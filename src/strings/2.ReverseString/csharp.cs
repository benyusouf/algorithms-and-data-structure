/// https://leetcode.com/problems/reverse-string/
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