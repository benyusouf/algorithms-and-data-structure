/*

A transformation sequence from word beginWord to word endWord using a dictionary wordList is a sequence of words beginWord -> s1 -> s2 -> ... -> sk such that:

Every adjacent pair of words differs by a single letter.
Every si for 1 <= i <= k is in wordList. Note that beginWord does not need to be in wordList.
sk == endWord
Given two words, beginWord and endWord, and a dictionary wordList, return the number of words in the shortest transformation sequence from beginWord to endWord, or 0 if no such sequence exists.
*/

/// <summary>
/// https://leetcode.com/problems/word-ladder/
/// </summary>

public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        Dictionary<string, int> validWordList = new Dictionary<string, int>();
        foreach(string s in wordList){
            validWordList.Add(s, 1);
        }
        Dictionary<string, int> visited = new Dictionary<string, int>();
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(new Node(beginWord, 1));
        visited.Add(beginWord, 1);
        
        while(q.Count() > 0){
            Node t = q.Dequeue();
            
            if(t.Word == endWord){
                return t.Dist;
            }
            
            for(int i=0; i<t.Word.Length; i++){
                for(int j=0;j<26;j++){
                    string newWord = t.Word;
                    var sb = new StringBuilder(newWord);
                    sb.Remove(i, 1);
                    sb.Insert(i, (char)(97 + j));
                    newWord = sb.ToString();
                    if(validWordList.ContainsKey(newWord) && 
                       !visited.ContainsKey(newWord)){
                        q.Enqueue(new Node(newWord, t.Dist+1));
                        visited.Add(newWord, 1);
                    }
                }
            }
        }
        return 0;
    }
}

public struct Node{
        public Node(string word, int dist){
            Word = word;
            Dist = dist;
        }
        public string Word {get; set;}
        public int Dist {get; set;}
    };