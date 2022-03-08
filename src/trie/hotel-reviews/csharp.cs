

class Solution {
    public List<int> solve(string A, List<string> B) {
        string[] words = A.Split("_");

        TrieNode root = new TrieNode();
        Trie trie = new Trie();

        foreach(string word in words){
            trie.Add(word, root);
        }

        List<KeyValuePair<int, int>> dic = new List<KeyValuePair<int, int>>();

        for(int i = 0; i < B.Count; i++){
            int count = 0;

            string[] temp = B[i].Split("_");

            foreach(string s in temp){
                if(trie.Search(s, root)) count++;
            }

            dic.Add(new KeyValuePair<int, int>(count, i));
        }

        return dic.OrderByDescending(x => x.Key).Select(x => x.Value).ToList();
    }
}

public class TrieNode{

  public TrieNode[] Children {get; set;}
  public bool IsTerminal {get; set;}

  public TrieNode(){
    IsTerminal = false;
    Children = new TrieNode[26];
  }
}

public class Trie {
  public void Add(string word, TrieNode node){
    int n = word.Length;
    for(int i=0;i<n;i++){
        if(node.Children[word[i] - 'a'] == null){
            node.Children[word[i] - 'a'] = new TrieNode();
        }
        node = node.Children[word[i] - 'a'];
    }
    node.IsTerminal = true;
}

public bool Search(string word, TrieNode node){
    int n = word.Length;
    for(int i=0;i<n;i++){
        if(node.Children[word[i] - 'a'] == null) return false;
        node = node.Children[word[i] - 'a'];
    }
    return node.IsTerminal;
  }
}
