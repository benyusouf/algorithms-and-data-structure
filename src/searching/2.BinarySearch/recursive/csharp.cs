using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    int[] a = {1,2,3,4,5,6,7,8,9};

    Console.WriteLine (BinarySearch(a, 9));
  }

  static int BinarySearch(int[] a, int key){
    if(a == null || a.Length == 0) return -1;
    return Search(a, 0, a.Length-1, key);
  }

  static int Search(int[] a, int s, int e, int key){
    if(s > e) return -1;

    int m = s + (e-s)/2;

    if(a[m] == key) return m;

    if(key > m)
    return Search(a, m+1, e, key);

    return Search(a, s, m-1, key);
  }
}