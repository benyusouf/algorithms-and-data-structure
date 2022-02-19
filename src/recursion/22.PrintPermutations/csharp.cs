using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    char[] ar = {'a', 'b', 'c', 'd',};
    PrintPermutations(ar);
  }

  static void PrintPermutations(char[] s){
    Print(s, 0);
  }

  static void Print(char[] s, int i){
    if(i == s.Length - 1){
      Console.WriteLine(s);
      return;
    }

    for(int j = i; j < s.Length; j++){
      Swap(s, i, j);
      Print(s, i+1);
      Swap(s, i, j);
    }
  }

  static void Swap(char[] s, int i, int j){
    char temp = s[i];
    s[i] = s[j];
    s[j] = temp;
  }
}