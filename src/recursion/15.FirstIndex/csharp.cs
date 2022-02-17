using System;

class Program {
  public static void Main (string[] args) {
    int[] a = {1, 2, 1};
    Console.WriteLine (FindFirstIndex(a, 2));
  }

  static int FindFirstIndex(int[] a, int e){
    return FirstIndex(a, 0, e);
  }

  static int FirstIndex(int[] a, int s, int e){
    if(a == null || a.Length == 0) return -1;
    if(s == a.Length -1) return a[a.Length-1] == e ? a.Length -1 : -1;
    if((a[s] == e)) return s;

    return FirstIndex(a, s+1, e);
  }
}