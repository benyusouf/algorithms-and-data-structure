using System;

class Program {
  public static void Main (string[] args) {
    int[] a = {1, 2, 1};
    Console.WriteLine (FindOccurence(a, 1));
  }

  static int FindOccurence(int[] a, int e){
    return Occurence(a, 0, e);
  }

  static int Occurence(int[] a, int s, int e){
    if(a == null || a.Length == 0) return 0;
    if(s == a.Length) return 0;

    int c = 0;

    if(a[s] == e) c += 1;

    return Occurence(a, s+1, e) + c;
  }
}