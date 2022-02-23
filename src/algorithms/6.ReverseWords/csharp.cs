/// <summary>
/// https://leetcode.com/problems/reverse-words-in-a-string/
/// </summary>
/*
Given an input string s, reverse the order of the words.

A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.

Return a string of the words in reverse order concatenated by a single space.

Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.
*/

public class Solution {

    /// <summary>
    /// Using two pointers and StringBuilder
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string ReverseWords(string str) {
            StringBuilder sb = new StringBuilder();
            int wordStart = 0;
            int wordEnd = str.Length-1;
            int currIndex = str.Length - 1;
            while(currIndex>= 0)
            {
                while (currIndex>=0 && str[currIndex] == ' ')
                {
                    currIndex--;
                }
                wordEnd = currIndex;
                while (currIndex >= 0 && str[currIndex] != ' ')
                {
                    currIndex--;
                }
                wordStart = currIndex + 1;
                if(wordStart >= 0)
                {
                    sb.Append(str.Substring(wordStart, wordEnd - wordStart + 1));

                }
                sb.Append(" ");
                currIndex--;
            }
            return sb.ToString().Trim();

    }

    /// <summary>
    /// Using Split, and StringBuilder
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string ReverseWords2(string str){
        string[] arr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        StringBuilder sb = new StringBuilder();
        for(int i = arr.Length - 1; i >= 0; i--)
        {
            sb.Append(arr[i]);
            sb.Append(" ");
        }
        
        return sb.ToString().TrimEnd();
    }
    /// <summary>
    /// Using Stack and StringBuilder
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string ReverseWords3(string str){
        
        string[] arr = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        
        Stack<string> helper = new Stack<string>();
        
        foreach(string word in arr){
            helper.Push(word);
        }
        
        StringBuilder sb = new StringBuilder();
        
        while(helper.Count > 0){
            sb.Append(helper.Pop());
            sb.Append(" ");
        }
        
        return sb.ToString().TrimEnd();
    }
    /// <summary>
    /// Using Split, Reverse and Join
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string ReverseWords4(string str){

        string[] arr = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        
        Array.Reverse(arr);
        
        return String.Join(" ", arr);
    }
}