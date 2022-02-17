using System;

class Program {
  public static void Main (string[] args) {
    int[] a = {1, 2, 1};
    Console.WriteLine (Sum(a));
  }

  static int Sum(int[] a){
    return GetSum(a, 0);
  }

  static int GetSum(int[] a, int s){
    if(a == null || a.Length == 0) return 0;
    if(s == a.Length -1) return a[a.Length-1];

    return GetSum(a, s+1) + a[s];
  }
}