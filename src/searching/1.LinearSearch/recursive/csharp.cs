using System;

class Program {
  public static void Main (string[] args) {
    int[] a = {1,2,3,4,5,6,7,8,2,9};

    Console.WriteLine(FindFirstIndex(a, 2));
    Console.WriteLine(FindLastIndex(a, 2));
  }

  static int FindFirstIndex(int[] a, int key){
    if(a == null || a.Length == 0) return -1;
    return FirstIndex(a, key, 0);
  }

  static int FindLastIndex(int[] a, int key){
    if(a == null || a.Length == 0) return -1;
    return LastIndex(a, key, a.Length -1);
  }

  static int FirstIndex(int[] a, int key, int i){
    if(i == a.Length) return -1;

    if(a[i] == key) return i;

    return FirstIndex(a, key, i+1);
  }

  static int LastIndex(int[] a, int key, int i){
    if(i < 0) return -1;

    if(a[i] == key) return i;

    return FirstIndex(a, key, i-1);
  }
}