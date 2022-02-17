using System;

class Program {
  public static void Main (string[] args) {
    int[] a = {1, 2, 1};
    Console.WriteLine (IsSorted(a));
  }

  static bool IsSorted(int[] a){
    return Helper(a, 0);
  }

  static bool Helper(int[] a, int s){
      if(a.Length < 2) return true;
    if(s == a.Length -1) return true;

    return IsSorted(a, s+1) && (a[s] <= a[s+1]);
  }
}