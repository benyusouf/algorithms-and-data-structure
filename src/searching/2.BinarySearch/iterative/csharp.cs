using System;

class Program {
  public static void Main (string[] args) {
    int[] a = {1,2,3,4,5,6,7,8,9};

    Console.WriteLine (BinarySearch(a, 2));
  }

  static int BinarySearch(int[] a, int key){
    if(a == null || a.Length == 0) return -1;
    int s = 0, e = a.Length - 1;

    while(s <= e){
      int m = s + (e-s)/2;
      if(a[m] == key) return m;

      if(a[m] < key){
        s = m + 1;
      } else {
        e = m - 1;
      }
    }

    return -1;
  }
}