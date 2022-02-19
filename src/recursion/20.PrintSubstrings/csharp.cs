using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    PrintSubsequences("abcd");
  }

  static void PrintSubsequences(string s){
    Print(s, "");
  }

  static void Print(string i, string o){
    if(i.Length == 0){
      Console.WriteLine(o);
      return;
    }
    Print(i.Substring(1), o);
    Print(i.Substring(1), o+ i[0]);
  }
}