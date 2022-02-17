using System;

class Program {
  public static void Main (string[] args) {
    int[] a = {2, 2, 1, 2, 2};
    Console.WriteLine (IsPallindrome(a));
  }

  static bool IsPallindrome(int[] a){
    if(a == null) return false;
    return CheckPallindrome(a, 0, a.Length-1);
  }

  static bool CheckPallindrome(int[] a, int s, int e){
    if(a.Length == 0) return false;
    if(s > e) return true;

    return (a[s] == a[e]) && CheckPallindrome(a, s+1, e-1);
    
  }
}