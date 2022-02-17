/// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string-ii/
/*
You are given a string s and an integer k, a k duplicate removal consists of choosing k adjacent and equal letters from s and removing them, causing the left and the right side of the deleted substring to concatenate together.

We repeatedly make k duplicate removals on s until we no longer can.

Return the final string after all such duplicate removals have been made. It is guaranteed that the answer is unique.

*/

public class Solution {
    public string RemoveDuplicates(string s, int k) {
        var helper = new Stack<Pair>();
        var result = string.Empty;
        for(int i = 0; i < s.Length; i++){
            if(helper.Count == 0 || helper.Peek().Key != s[i])
                helper.Push(new Pair(s[i], 1));
            else{
                    helper.Peek().Value++;
                    if(helper.Peek().Value == k){
                        helper.Pop();
                    }
            }
                
        }
        
        while(helper.Count != 0){
            for(int i = helper.Peek().Value; i > 0; i--){
                result = $"{helper.Peek().Key}{result}";
            }
            helper.Pop();
        }
        return result;
    }
}

public class Pair{
    public int Value {get; set;}
    public char Key {get; set;}
    
    public Pair(char key, int count){
        Key = key;
        Value = count;
    }
}