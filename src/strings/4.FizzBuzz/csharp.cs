/// https://leetcode.com/problems/fizz-buzz/
/*
Given an integer n, return a string array answer (1-indexed) where:

answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
answer[i] == "Fizz" if i is divisible by 3.
answer[i] == "Buzz" if i is divisible by 5.
answer[i] == i (as a string) if none of the above conditions are true.
*/

public class Solution {
    public IList<string> FizzBuzz(int n) {
        var result = new List<string>();
        
        for(int i = 1; i <= n; i++){
            if(i%3==0 && i%5 == 0) result.Add("FizzBuzz");
            else if(i%3==0) result.Add("Fizz");
            else if(i%5 == 0) result.Add("Buzz");
            else result.Add(i.ToString());
        }
        
        return result;
    }
}