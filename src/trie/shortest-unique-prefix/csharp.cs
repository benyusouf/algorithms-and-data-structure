class Solution {
    public List<string> prefix(List<string> A) {
        TrieNode root = new TrieNode();
        Trie trie = new Trie();

        foreach(string s in A){
            trie.Add(s, root);
        }

        List<string> result = new List<string>();

        foreach(string s in A){
            result.Add(trie.GetUniquePrefix(s, root));
        }

        return result;
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
                node.Children[word[i] - 'a'].IsTerminal = true;
            }
            else{
                node.Children[word[i] - 'a'].IsTerminal = false;
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

   public string GetUniquePrefix(string word, TrieNode node){
        int n = word.Length;
        string result = "";
        for(int i=0;i<n;i++){
            if(node.Children[word[i] - 'a'] == null) return result;
            result += word[i];
            if(node.Children[word[i] - 'a'].IsTerminal) return result;
            node = node.Children[word[i] - 'a'];
        }
        return result;
   }
}
