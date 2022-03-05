using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    int[] arr = {10, 12, 6, 7, 9};
    KSorted(arr, 3);

    for(int i = 0; i < arr.Length; i++){
       Console.WriteLine (arr[i]);
    }
  }

  public static void KSorted(int[] arr, int k){
    MaxPriorityQueue q = new MaxPriorityQueue();

    for(int i = 0; i < k; i++){
      q.Enqueue(arr[i]);
    }

    int s = 0;

    for(int i = k; i < arr.Length; i++){
      arr[s] = q.Dequeue();
      s++;
      q.Enqueue(arr[i]);
    }

    while(q.Count() > 0 ){
      arr[s] = q.Dequeue();
      s++;
    }
  }
}

public class MaxPriorityQueue {
  private IList<int> items;

  public MaxPriorityQueue(){
    items = new List<int>();
  }

  public int Count(){
    return items.Count;
  }

  public bool IsEmpty(){
    return items.Count == 0;
  }

  public int Peek(){
    if(items.Count == 0) return default;
    return items[0];
  }

  public void Enqueue(int item){
    items.Add(item);

    int ci = items.Count - 1;

    while(ci > 0){
      int pi = (ci -1)/2;

      if(items[ci] > items[pi] ){
        Swap(ci, pi);
        ci = pi;
      }
      else break;
    }
  }

  public int Dequeue(){
    if(IsEmpty()){
            return default;  /// items is empty
      }
     int ans = items[0];
     Swap(0, items.Count-1);
     items.RemoveAt(items.Count -1);

     /// CBT yes , Heap no
     /// Down Heapify

     int pi = 0;
     while(true){
        int lci = 2*pi + 1;
        int rci = 2*pi + 2;
        int mini = pi;

        if(lci < items.Count && items[lci] > items[mini]){
            mini = lci;
        }
        if(rci < items.Count && items[rci] > items[mini]){
            mini = rci;
        }

        if(mini == pi){
            break;
        }
        Swap(pi, mini);
        pi = mini;
    }
    return ans;
  }

  private void Swap(int i, int j){
    int temp = items[i];
    items[i] = items[j];
    items[j] = temp;
  }
}