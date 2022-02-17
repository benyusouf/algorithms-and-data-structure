using System;

class Program {
  public static void Main (string[] args) {
    int[] a = {1, 3, 6, 7};
    PrintPositions(a);
  }

  static void PrintPositions(int[] a){
    PrintPosition(a, 0);
  }

  static void PrintPosition(int[] a, int s){
    if(a == null || a.Length == 0) return;
    if(s == a.Length ) return;

    Console.WriteLine(s);

    PrintPosition(a, s+1);
  }
}