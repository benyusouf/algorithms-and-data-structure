using System;

class Program {
  public static void Main (string[] args) {
    int[] a = {1, 2, 1};
    Console.WriteLine (ElementExist(a, 4));
  }

  static bool ElementExist(int[] a, int e){
    return Exist(a, 0, e);
  }

  static bool Exist(int[] a, int s, int e){
    if(a == null || a.Length == 0) return false;
    if(s == a.Length -1) return a[a.Length-1] == e;
    if((a[s] == e)) return true;

    return Exist(a, s+1, e);
  }
}