using System;

class Program {
  public static void Main (string[] args) {
    int[] a = {1, 2, 1};
    Console.WriteLine (FindLastIndex(a, 1));
  }

  static int FindLastIndex(int[] a, int n){
    if(a == null || a.Length == 0) return -1;
    return LastIndex(a, a.Length - 1, n);
  }

  static int LastIndex(int[] a, int e, int n){
    if(e == 0) return a[e] == n ? e : -1;
    if(a[e] == n) return e;

    return LastIndex(a, e-1, n);
  }
}