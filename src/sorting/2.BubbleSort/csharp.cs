using System;

class Program {
  public static void Main (string[] args) {

    int[] a = {7, 8,3,1,0,3,7,5,4,2};
    BubbleSort(a);

    for(int i=0; i < a.Length; i++){
      Console.WriteLine (a[i]);
    }
    
  }

  static void BubbleSort(int[] a){
    int n = a.Length;

    for(int i = 1; i < n; i++){
      for(int j = 0; j < n-1; j++)
        if(a[j] > a[j+1])
          Swap(a, j, j+1);
    }
  }

  static void Swap(int[] a, int i, int j){
    int temp = a[i];
    a[i] = a[j];
    a[j] = temp;
  }
}