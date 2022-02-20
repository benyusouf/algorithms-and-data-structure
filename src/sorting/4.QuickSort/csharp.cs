using System;

class Program {

  static void Sort(int[] arr){
    QuickSort(arr, 0, arr.Length-1);
  }

  static void QuickSort(int[] arr, int s, int e){
    //base case here
    if(s >= e) return;

    int p = Pertition(arr, s, e);

    QuickSort(arr, s, p-1);
    QuickSort(arr, p+1, e);
  }

  static int Pertition(int[] arr, int s, int e){
    int pivot = arr[e], i = s;

    for(int j = s; j < e; j++)
      if(arr[j] < pivot){
        SwapElements(arr, j, i);
        i++;
      }
    SwapElements(arr, i, e);
    return i;
  }

  static void SwapElements(int[] arr, int i, int j){
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
  }

  static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
  
    public static void Main(String[] args)
    {
        int[] arr = { 12, 11, 13, 5, 6, 7, 8 };
        Console.WriteLine("Given Array");
        PrintArray(arr);
        Sort(arr);
        Console.WriteLine("\nSorted array");
        PrintArray(arr);
    }

    static int GetPertition(int[] arr, int s, int e){
      int pivot = arr[e], i = s;

      for(int j = s; j < e; j++){
        if(arr[j] < pivot){
          SwapElements(arr, j, i);
          i++;
        }
      }
      SwapElements(arr, i, e);
      return i;
    }
}