using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    List<string> words = new List<string> {"ARE", "MAN", "NO", "TRUE"};
    TrieNode root = new TrieNode();
    Trie trie = new Trie();

    foreach(string word in words){
      trie.Add(word, root);
    }

    Console.WriteLine(trie.Search("MAN", root));
    Console.WriteLine(trie.Search("TRUE", root));
    Console.WriteLine(trie.Search("MUMU", root));
    Console.WriteLine(trie.Search("LOL", root));
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
        if(node.Children[word[i] - 'A'] == null){
            node.Children[word[i] - 'A'] = new TrieNode();
        }
        node = node.Children[word[i] - 'A'];
    }
    node.IsTerminal = true;
}

public bool Search(string word, TrieNode node){
    int n = word.Length;
    for(int i=0;i<n;i++){
        if(node.Children[word[i] - 'A'] == null) return false;
        node = node.Children[word[i] - 'A'];
    }
    return node.IsTerminal;
  }
}