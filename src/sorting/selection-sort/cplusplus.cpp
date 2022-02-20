#include<iostream>
using namespace std;

 void selectionSort(int[] a){
    int n = a.length;

    for(int i = 0; i < n-1; i++){
      int indexOfSmallest = i;

      for(int j = i+1; j < n; j++)
        if(a[j] < a[indexOfSmallest])
          indexOfSmallest = j;
      if(a[indexOfSmallest]  < a[i])
        swap(a[i], a[indexOfSmallest]);
    }
  }

int main(){
    int[] a = {7, 8,3,1,0,3,7,5,4,2};
    selectionSort(a);

    for(int i=0; i < a.length; i++){
      Console.WriteLine (a[i]);
    }

  return 0;
}