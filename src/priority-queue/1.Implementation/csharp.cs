using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {
   MinPriorityQueue p = new MinPriorityQueue();
   p.Enqueue(100);
   p.Enqueue(10);
   p.Enqueue(15);
   p.Enqueue(4);
   p.Enqueue(17);
   p.Enqueue(21);
   p.Enqueue(67);

    Console.WriteLine(p.Count());
    Console.WriteLine(p.Peek());

   while(!p.IsEmpty()){
    Console.WriteLine(p.Dequeue());
   }
  }
}

public class MinPriorityQueue {
  private IList<int> items;

  public MinPriorityQueue(){
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

      if(items[ci] < items[pi] ){
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

        if(lci < items.Count && items[lci] < items[mini]){
            mini = lci;
        }
        if(rci < items.Count && items[rci] < items[mini]){
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