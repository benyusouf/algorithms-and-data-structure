using System;

class Program {
  public static void Main (string[] args) {

    int[] a = {7, 8,3,1,0,3,7,5,4,2};
    SelectionSort(a);

    for(int i=0; i < a.Length; i++){
      Console.WriteLine (a[i]);
    }
    
  }

  static void SelectionSort(int[] a){
    int n = a.Length;

    for(int i = 0; i < n-1; i++){
      int indexOfSmallest = i;

      for(int j = i+1; j < n; j++)
        if(a[j] < a[indexOfSmallest])
          indexOfSmallest = j;
      if(a[indexOfSmallest]  < a[i])
        Swap(a, i, indexOfSmallest);
    }
  }

  static void Swap(int[] a, int i, int j){
    int temp = a[i];
    a[i] = a[j];
    a[j] = temp;
  }
}