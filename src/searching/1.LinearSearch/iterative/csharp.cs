using System;

class Program {
  public static void Main (string[] args) {
   int[] a = {1,2,3,4,5,6,7,8,2,9};

    Console.WriteLine(FindFirstIndex(a, 10));
    Console.WriteLine(FindLastIndex(a, 10));
  }

  static int FindFirstIndex(int[] a, int key){
    if(a == null || a.Length == 0) return -1;
    for(int i = 0; i < a.Length; i++){
      if(a[i] == key) return i;
    }

    return -1;
  }

  static int FindLastIndex(int[] a, int key){
    if(a == null || a.Length == 0) return -1;
    for(int i = a.Length -1; i >= 0; i--){
      if(a[i] == key) return i;
    }

    return -1;
  }
}